USE [BDHOTEL]
GO

/****** Object: Table [dbo].[QUARTOS] Script Date: 02/12/2021 17:57:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QUARTOS] (
    [NUMEROQUARTO] INT            NOT NULL,
    [TIPODOQUARTO] NVARCHAR (50)  NOT NULL,
    [HOSPEDES]     NVARCHAR (200) NULL,
    [STATUS]       NVARCHAR (50)  NOT NULL,
    [ENTRADA]      DATE           NULL,
    [SAÍDA]        DATE           NULL,
    [VALOR]        DECIMAL (38)   NULL
);


