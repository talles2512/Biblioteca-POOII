
-- VERSAO 1.0 REVISÃO 1.0

-- status usuario
-- 'B' -- usuario bloqueado (não pode fazer empréstimos)
-- 'A' -- usuario Ativo


-- status Administradores
-- 'B' -- Administrador bloqueado (não pode usar o login programa)
-- 'A' -- Administrador Ativo

-- Motivo atraso
-- 'A' -- Atraso simples gera multa de 0,50 por dia
-- 'D' -- Usuario danificou a obra deve pagar o valor do livro

-- Status Livro
-- 'E' -- O Livro Pode ser emprestado
-- 'C' -- O Livro so pode ser consultado na Biblioteca

USE [master]
GO

IF EXISTS (SELECT NAME FROM master.sys.databases WHERE NAME = N'BibliotecaPOOII')
DROP DATABASE [BibliotecaPOOII]
GO

CREATE DATABASE [BibliotecaPOOII]
GO

-- Asegura qye voce esta na base correta
USE [BibliotecaPOOII]
GO

-- berifica se a tabela a existe, e se existir apaga a mesma

IF OBJECT_ID('tbLivrosAutores', 'U') IS NOT NULL  
DROP TABLE tbLivrosAutores; 
GO

IF OBJECT_ID('tbAutores', 'U') IS NOT NULL  
DROP TABLE tbAutores; 
GO

IF OBJECT_ID('tbMultas', 'U') IS NOT NULL  
DROP TABLE tbMultas; 
GO

IF OBJECT_ID('tbEmprestimo', 'U') IS NOT NULL  
DROP TABLE tbEmprestimo; 
GO

IF OBJECT_ID('tbUsuario', 'U') IS NOT NULL  
DROP TABLE tbUsuario; 
GO

IF OBJECT_ID('tbLivros', 'U') IS NOT NULL  
DROP TABLE tbLivros; 
GO

IF OBJECT_ID('tbAdministradores', 'U') IS NOT NULL  
DROP TABLE tbAdministradores;
GO

CREATE TABLE [tbAdministradores]
( 
	[Login]              varchar(20)  NOT NULL ,
	[Senha]              varchar(20)  NOT NULL ,
	[Status]             char  NOT NULL 
	CONSTRAINT [ConstraintStatusAdministradores]
		CHECK  ( [Status]='B' OR [Status]='A' )
)
go

ALTER TABLE [tbAdministradores]
	ADD CONSTRAINT [XPKtbAdministradores] PRIMARY KEY  CLUSTERED ([Login] ASC)
go

CREATE TABLE [tbAutores]
( 
	[CodAutor]           integer  NOT NULL ,
	[NomeAutor]          varchar(200)  NULL ,
	[DataEntrada]        datetime  NOT NULL 
)
go

ALTER TABLE [tbAutores]
	ADD CONSTRAINT [XPKtbAutores] PRIMARY KEY  CLUSTERED ([CodAutor] ASC)
go

CREATE TABLE [tbEmprestimo]
( 
	[CodLivro]           int  NOT NULL ,
	[CodUsuario]         integer  NOT NULL ,
	[DataEmprestimo]     datetime  NOT NULL ,
	[DataDevolucao]      datetime  NULL ,
	[DiasEmprestimo]     integer  NOT NULL 
	CONSTRAINT [Quantidade]
		CHECK  ( DiasEmprestimo>0 )
)
go

ALTER TABLE [tbEmprestimo]
	ADD CONSTRAINT [XPKtbEmprestimo] PRIMARY KEY  CLUSTERED ([CodLivro] ASC,[CodUsuario] ASC)
go

CREATE TABLE [tbLivros]
( 
	[CodLivro]           int  NOT NULL ,
	[Titulo]             varchar(200)  NOT NULL ,
	[ISBN]               varchar(20)  NOT NULL ,
	[DataEntrada]        datetime  NOT NULL ,
	[Status]             char  NOT NULL 
	CONSTRAINT [ConstraintStatusLivros]
		CHECK  ( [Status]='E' OR [Status]='C' ),
	[Quantidade]         integer  NOT NULL 
	CONSTRAINT [ConstraintQuantidadeLivrosBiblioteca]
		CHECK  ( Quantidade>0 ),
	[Valor]              money  NOT NULL 
)
go

ALTER TABLE [tbLivros]
	ADD CONSTRAINT [XPKtbLivros] PRIMARY KEY  CLUSTERED ([CodLivro] ASC)
go

CREATE TABLE [tbLivrosAutores]
( 
	[CodLivro]           int  NOT NULL ,
	[CodAutor]           integer  NOT NULL ,
	[DataEntrada]        datetime  NOT NULL 
)
go

ALTER TABLE [tbLivrosAutores]
	ADD CONSTRAINT [XPKtbLivrosAutores] PRIMARY KEY  CLUSTERED ([CodLivro] ASC,[CodAutor] ASC)
go

CREATE TABLE [tbMultas]
( 
	[Valor]              money  NOT NULL ,
	[MotivoMulta]        char  NOT NULL 
	CONSTRAINT [ConstraintMotivoAtraso]
		CHECK  ( [MotivoMulta]='A' OR [MotivoMulta]='D' ),
	[DescricaoMotivo]    varchar(max)  NULL ,
	[CodLivro]           int  NOT NULL ,
	[CodUsuario]         integer  NOT NULL 
)
go

ALTER TABLE [tbMultas]
	ADD CONSTRAINT [XPKtbMultas] PRIMARY KEY  CLUSTERED ([CodLivro] ASC,[CodUsuario] ASC)
go

CREATE TABLE [tbUsuario]
( 
	[CodUsuario]         integer  NOT NULL ,
	[NomeUsuario]        varchar(200)  NOT NULL ,
	[DataEntrada]        datetime  NOT NULL ,
	[Status]             char  NOT NULL 
	CONSTRAINT [ConstraintStatusUsuario]
		CHECK  ( [Status]='B' OR [Status]='A' )
)
go

ALTER TABLE [tbUsuario]
	ADD CONSTRAINT [XPKtbUsuario] PRIMARY KEY  CLUSTERED ([CodUsuario] ASC)
go


ALTER TABLE [tbEmprestimo]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([CodLivro]) REFERENCES [tbLivros]([CodLivro])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [tbEmprestimo]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([CodUsuario]) REFERENCES [tbUsuario]([CodUsuario])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [tbLivrosAutores]
	ADD CONSTRAINT [R_4] FOREIGN KEY ([CodLivro]) REFERENCES [tbLivros]([CodLivro])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [tbLivrosAutores]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([CodAutor]) REFERENCES [tbAutores]([CodAutor])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [tbMultas]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([CodLivro],[CodUsuario]) REFERENCES [tbEmprestimo]([CodLivro],[CodUsuario])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


CREATE TRIGGER tD_tbAutores ON tbAutores FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbAutores */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbAutores  tbLivrosAutores on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00011970", PARENT_OWNER="", PARENT_TABLE="tbAutores"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodAutor" */
    IF EXISTS (
      SELECT * FROM deleted,tbLivrosAutores
      WHERE
        /*  %JoinFKPK(tbLivrosAutores,deleted," = "," AND") */
        tbLivrosAutores.CodAutor = deleted.CodAutor
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete tbAutores because tbLivrosAutores exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbAutores ON tbAutores FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbAutores */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodAutor integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbAutores  tbLivrosAutores on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000130f7", PARENT_OWNER="", PARENT_TABLE="tbAutores"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodAutor" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodAutor)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,tbLivrosAutores
      WHERE
        /*  %JoinFKPK(tbLivrosAutores,deleted," = "," AND") */
        tbLivrosAutores.CodAutor = deleted.CodAutor
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update tbAutores because tbLivrosAutores exists.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_tbEmprestimo ON tbEmprestimo FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbEmprestimo */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbEmprestimo  tbMultas on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00039b8c", PARENT_OWNER="", PARENT_TABLE="tbEmprestimo"
    CHILD_OWNER="", CHILD_TABLE="tbMultas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodLivro""CodUsuario" */
    IF EXISTS (
      SELECT * FROM deleted,tbMultas
      WHERE
        /*  %JoinFKPK(tbMultas,deleted," = "," AND") */
        tbMultas.CodLivro = deleted.CodLivro AND
        tbMultas.CodUsuario = deleted.CodUsuario
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete tbEmprestimo because tbMultas exists.'
      GOTO error
    END

    /* ERwin Builtin Trigger */
    /* tbUsuario  tbEmprestimo on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbUsuario"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodUsuario" */
    IF EXISTS (SELECT * FROM deleted,tbUsuario
      WHERE
        /* %JoinFKPK(deleted,tbUsuario," = "," AND") */
        deleted.CodUsuario = tbUsuario.CodUsuario AND
        NOT EXISTS (
          SELECT * FROM tbEmprestimo
          WHERE
            /* %JoinFKPK(tbEmprestimo,tbUsuario," = "," AND") */
            tbEmprestimo.CodUsuario = tbUsuario.CodUsuario
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last tbEmprestimo because tbUsuario exists.'
      GOTO error
    END

    /* ERwin Builtin Trigger */
    /* tbLivros  tbEmprestimo on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodLivro" */
    IF EXISTS (SELECT * FROM deleted,tbLivros
      WHERE
        /* %JoinFKPK(deleted,tbLivros," = "," AND") */
        deleted.CodLivro = tbLivros.CodLivro AND
        NOT EXISTS (
          SELECT * FROM tbEmprestimo
          WHERE
            /* %JoinFKPK(tbEmprestimo,tbLivros," = "," AND") */
            tbEmprestimo.CodLivro = tbLivros.CodLivro
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last tbEmprestimo because tbLivros exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbEmprestimo ON tbEmprestimo FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbEmprestimo */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodLivro int, 
           @insCodUsuario integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbEmprestimo  tbMultas on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0003fd02", PARENT_OWNER="", PARENT_TABLE="tbEmprestimo"
    CHILD_OWNER="", CHILD_TABLE="tbMultas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodLivro""CodUsuario" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodLivro) OR
    UPDATE(CodUsuario)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,tbMultas
      WHERE
        /*  %JoinFKPK(tbMultas,deleted," = "," AND") */
        tbMultas.CodLivro = deleted.CodLivro AND
        tbMultas.CodUsuario = deleted.CodUsuario
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update tbEmprestimo because tbMultas exists.'
      GOTO error
    END
  END

  /* ERwin Builtin Trigger */
  /* tbUsuario  tbEmprestimo on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbUsuario"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodUsuario" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodUsuario)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,tbUsuario
        WHERE
          /* %JoinFKPK(inserted,tbUsuario) */
          inserted.CodUsuario = tbUsuario.CodUsuario
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update tbEmprestimo because tbUsuario does not exist.'
      GOTO error
    END
  END

  /* ERwin Builtin Trigger */
  /* tbLivros  tbEmprestimo on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodLivro" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodLivro)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,tbLivros
        WHERE
          /* %JoinFKPK(inserted,tbLivros) */
          inserted.CodLivro = tbLivros.CodLivro
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update tbEmprestimo because tbLivros does not exist.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_tbLivros ON tbLivros FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbLivros */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbLivros  tbLivrosAutores on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00020755", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_4", FK_COLUMNS="CodLivro" */
    IF EXISTS (
      SELECT * FROM deleted,tbLivrosAutores
      WHERE
        /*  %JoinFKPK(tbLivrosAutores,deleted," = "," AND") */
        tbLivrosAutores.CodLivro = deleted.CodLivro
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete tbLivros because tbLivrosAutores exists.'
      GOTO error
    END

    /* ERwin Builtin Trigger */
    /* tbLivros  tbEmprestimo on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodLivro" */
    IF EXISTS (
      SELECT * FROM deleted,tbEmprestimo
      WHERE
        /*  %JoinFKPK(tbEmprestimo,deleted," = "," AND") */
        tbEmprestimo.CodLivro = deleted.CodLivro
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete tbLivros because tbEmprestimo exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbLivros ON tbLivros FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbLivros */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodLivro int,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbLivros  tbLivrosAutores on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000242bb", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_4", FK_COLUMNS="CodLivro" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodLivro)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,tbLivrosAutores
      WHERE
        /*  %JoinFKPK(tbLivrosAutores,deleted," = "," AND") */
        tbLivrosAutores.CodLivro = deleted.CodLivro
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update tbLivros because tbLivrosAutores exists.'
      GOTO error
    END
  END

  /* ERwin Builtin Trigger */
  /* tbLivros  tbEmprestimo on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodLivro" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodLivro)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,tbEmprestimo
      WHERE
        /*  %JoinFKPK(tbEmprestimo,deleted," = "," AND") */
        tbEmprestimo.CodLivro = deleted.CodLivro
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update tbLivros because tbEmprestimo exists.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_tbLivrosAutores ON tbLivrosAutores FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbLivrosAutores */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbAutores  tbLivrosAutores on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00028c5d", PARENT_OWNER="", PARENT_TABLE="tbAutores"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodAutor" */
    IF EXISTS (SELECT * FROM deleted,tbAutores
      WHERE
        /* %JoinFKPK(deleted,tbAutores," = "," AND") */
        deleted.CodAutor = tbAutores.CodAutor AND
        NOT EXISTS (
          SELECT * FROM tbLivrosAutores
          WHERE
            /* %JoinFKPK(tbLivrosAutores,tbAutores," = "," AND") */
            tbLivrosAutores.CodAutor = tbAutores.CodAutor
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last tbLivrosAutores because tbAutores exists.'
      GOTO error
    END

    /* ERwin Builtin Trigger */
    /* tbLivros  tbLivrosAutores on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_4", FK_COLUMNS="CodLivro" */
    IF EXISTS (SELECT * FROM deleted,tbLivros
      WHERE
        /* %JoinFKPK(deleted,tbLivros," = "," AND") */
        deleted.CodLivro = tbLivros.CodLivro AND
        NOT EXISTS (
          SELECT * FROM tbLivrosAutores
          WHERE
            /* %JoinFKPK(tbLivrosAutores,tbLivros," = "," AND") */
            tbLivrosAutores.CodLivro = tbLivros.CodLivro
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last tbLivrosAutores because tbLivros exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbLivrosAutores ON tbLivrosAutores FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbLivrosAutores */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodLivro int, 
           @insCodAutor integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbAutores  tbLivrosAutores on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002b95e", PARENT_OWNER="", PARENT_TABLE="tbAutores"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodAutor" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodAutor)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,tbAutores
        WHERE
          /* %JoinFKPK(inserted,tbAutores) */
          inserted.CodAutor = tbAutores.CodAutor
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update tbLivrosAutores because tbAutores does not exist.'
      GOTO error
    END
  END

  /* ERwin Builtin Trigger */
  /* tbLivros  tbLivrosAutores on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="tbLivros"
    CHILD_OWNER="", CHILD_TABLE="tbLivrosAutores"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_4", FK_COLUMNS="CodLivro" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodLivro)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,tbLivros
        WHERE
          /* %JoinFKPK(inserted,tbLivros) */
          inserted.CodLivro = tbLivros.CodLivro
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update tbLivrosAutores because tbLivros does not exist.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_tbMultas ON tbMultas FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbMultas */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbEmprestimo  tbMultas on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001851d", PARENT_OWNER="", PARENT_TABLE="tbEmprestimo"
    CHILD_OWNER="", CHILD_TABLE="tbMultas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodLivro""CodUsuario" */
    IF EXISTS (SELECT * FROM deleted,tbEmprestimo
      WHERE
        /* %JoinFKPK(deleted,tbEmprestimo," = "," AND") */
        deleted.CodLivro = tbEmprestimo.CodLivro AND
        deleted.CodUsuario = tbEmprestimo.CodUsuario AND
        NOT EXISTS (
          SELECT * FROM tbMultas
          WHERE
            /* %JoinFKPK(tbMultas,tbEmprestimo," = "," AND") */
            tbMultas.CodLivro = tbEmprestimo.CodLivro AND
            tbMultas.CodUsuario = tbEmprestimo.CodUsuario
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last tbMultas because tbEmprestimo exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbMultas ON tbMultas FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbMultas */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodLivro int, 
           @insCodUsuario integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbEmprestimo  tbMultas on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00018b0c", PARENT_OWNER="", PARENT_TABLE="tbEmprestimo"
    CHILD_OWNER="", CHILD_TABLE="tbMultas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodLivro""CodUsuario" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodLivro) OR
    UPDATE(CodUsuario)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,tbEmprestimo
        WHERE
          /* %JoinFKPK(inserted,tbEmprestimo) */
          inserted.CodLivro = tbEmprestimo.CodLivro and
          inserted.CodUsuario = tbEmprestimo.CodUsuario
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update tbMultas because tbEmprestimo does not exist.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_tbUsuario ON tbUsuario FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on tbUsuario */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* tbUsuario  tbEmprestimo on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00012555", PARENT_OWNER="", PARENT_TABLE="tbUsuario"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodUsuario" */
    IF EXISTS (
      SELECT * FROM deleted,tbEmprestimo
      WHERE
        /*  %JoinFKPK(tbEmprestimo,deleted," = "," AND") */
        tbEmprestimo.CodUsuario = deleted.CodUsuario
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete tbUsuario because tbEmprestimo exists.'
      GOTO error
    END


    /* ERwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_tbUsuario ON tbUsuario FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on tbUsuario */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodUsuario integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* ERwin Builtin Trigger */
  /* tbUsuario  tbEmprestimo on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00012f2f", PARENT_OWNER="", PARENT_TABLE="tbUsuario"
    CHILD_OWNER="", CHILD_TABLE="tbEmprestimo"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodUsuario" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodUsuario)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,tbEmprestimo
      WHERE
        /*  %JoinFKPK(tbEmprestimo,deleted," = "," AND") */
        tbEmprestimo.CodUsuario = deleted.CodUsuario
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update tbUsuario because tbEmprestimo exists.'
      GOTO error
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go

-- ============= POPUPLA DADOS INICIAIS DE CONFIGURACAO

Delete tbAdministradores;
INSERT INTO tbAdministradores(Login,Senha,Status)
VALUES('Admin','Admin','A');










