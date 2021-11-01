USE [BDHOTEL]
GO

/****** Object:  Table [dbo].[HOSPEDES]    Script Date: 23/10/2021 12:29:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HOSPEDES](
	[RG] [bigint] NOT NULL,
	[NOME] [nvarchar](50) NOT NULL,
	[ENDERECO] [nvarchar](50) NOT NULL,
	[TELEFONE] [nvarchar](15) NOT NULL,
	[EMAIL] [nvarchar](50) NULL,
	[DATANASCIMENTO] [date] NOT NULL,
	[NACIONALIDADE] [nvarchar](50) NOT NULL,
	[CPF] [bigint] NOT NULL,
	[LOCALDENASCIMENTO] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
