USE [Madeireira]
GO
ALTER TABLE [dbo].[VENDAS] DROP CONSTRAINT [FK__VENDAS__ID_VENDE__36B12243]
GO
ALTER TABLE [dbo].[VENDAS] DROP CONSTRAINT [FK__VENDAS__ID_CLIEN__35BCFE0A]
GO
ALTER TABLE [dbo].[VENDA_PRODUTO] DROP CONSTRAINT [FK__VENDA_PRO__ID_VE__34C8D9D1]
GO
ALTER TABLE [dbo].[VENDA_PRODUTO] DROP CONSTRAINT [FK__VENDA_PRO__ID_PR__33D4B598]
GO
ALTER TABLE [dbo].[PRODUTOS] DROP CONSTRAINT [FK__PRODUTOS__ID_FOR__32E0915F]
GO
ALTER TABLE [dbo].[FORNECIMENTOS] DROP CONSTRAINT [FK__FORNECIME__ID_FO__3E52440B]
GO
ALTER TABLE [dbo].[FORNECIMENTO_PRODUTO] DROP CONSTRAINT [FK__FORNECIME__ID_PR__4222D4EF]
GO
ALTER TABLE [dbo].[FORNECIMENTO_PRODUTO] DROP CONSTRAINT [FK__FORNECIME__ID_FO__412EB0B6]
GO
/****** Object:  Table [dbo].[VENDAS]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[VENDAS]
GO
/****** Object:  Table [dbo].[VENDA_PRODUTO]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[VENDA_PRODUTO]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[PRODUTOS]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[PRODUTOS]
GO
/****** Object:  Table [dbo].[FUNCIONARIOS]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[FUNCIONARIOS]
GO
/****** Object:  Table [dbo].[FORNECIMENTOS]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[FORNECIMENTOS]
GO
/****** Object:  Table [dbo].[FORNECIMENTO_PRODUTO]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[FORNECIMENTO_PRODUTO]
GO
/****** Object:  Table [dbo].[FORNECEDORES]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[FORNECEDORES]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 18/06/2018 17:39:38 ******/
DROP TABLE [dbo].[CLIENTES]
GO
/****** Object:  User [Otavio]    Script Date: 18/06/2018 17:39:38 ******/
DROP USER [Otavio]
GO
USE [master]
GO
/****** Object:  Database [Madeireira]    Script Date: 18/06/2018 17:39:38 ******/
DROP DATABASE [Madeireira]
GO
