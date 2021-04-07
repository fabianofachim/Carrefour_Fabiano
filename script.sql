USE [Carregour]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([IdCliente], [Nome], [RG], [Cpf], [DataNascimento], [Telefone], [Email], [Cod_Empresa]) VALUES (1, N'strin8', N'string', N'strin8', CAST(N'2021-04-02T20:12:32.2530000' AS DateTime2), N'string', N'string', N'1')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Nome], [RG], [Cpf], [DataNascimento], [Telefone], [Email], [Cod_Empresa]) VALUES (4, N'Fabiano', N'123456', N'123456', CAST(N'2021-04-04T19:46:30.9690000' AS DateTime2), N'string', N'string', N'1')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Nome], [RG], [Cpf], [DataNascimento], [Telefone], [Email], [Cod_Empresa]) VALUES (5, N'string4', N'string', N'string4', CAST(N'2021-04-04T19:46:30.9690000' AS DateTime2), N'string', N'string', N'1')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Nome], [RG], [Cpf], [DataNascimento], [Telefone], [Email], [Cod_Empresa]) VALUES (6, N'Fabiano 6', N'string', N'9876554', CAST(N'2021-04-04T19:46:30.9690000' AS DateTime2), N'string', N'string', N'1')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Enderecos] ON 
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (1, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (2, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (3, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (4, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (5, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
INSERT [dbo].[Enderecos] ([IdEndereco], [Rua], [Bairro], [Numero], [Complemento], [Cep], [Tipo_Endereco], [IdCidade]) VALUES (6, N'string', N'string', N'string', N'string', N'string', N'1', 1)
GO
SET IDENTITY_INSERT [dbo].[Enderecos] OFF
GO
SET IDENTITY_INSERT [dbo].[ClienteEndereco] ON 
GO
INSERT [dbo].[ClienteEndereco] ([IdClienteEndereco], [IdCliente], [IdEndereco]) VALUES (3, 4, 4)
GO
INSERT [dbo].[ClienteEndereco] ([IdClienteEndereco], [IdCliente], [IdEndereco]) VALUES (4, 5, 5)
GO
INSERT [dbo].[ClienteEndereco] ([IdClienteEndereco], [IdCliente], [IdEndereco]) VALUES (5, 6, 6)
GO
SET IDENTITY_INSERT [dbo].[ClienteEndereco] OFF
GO
SET IDENTITY_INSERT [dbo].[Cidade] ON 
GO
INSERT [dbo].[Cidade] ([IdCidade], [Nome], [Estado]) VALUES (1, N'São Paulo', N'Sp')
GO
INSERT [dbo].[Cidade] ([IdCidade], [Nome], [Estado]) VALUES (2, N'Cotia', N'Sp')
GO
INSERT [dbo].[Cidade] ([IdCidade], [Nome], [Estado]) VALUES (3, N'Rio de Janeiro', N'RJ')
GO
SET IDENTITY_INSERT [dbo].[Cidade] OFF
GO
