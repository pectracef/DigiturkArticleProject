USE [DigiturkArticleProject]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id], [createdAt], [updatedAt], [isDeleted], [name]) VALUES (1, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, N'Admin')
INSERT [dbo].[Role] ([id], [createdAt], [updatedAt], [isDeleted], [name]) VALUES (2, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, N'Editor')
INSERT [dbo].[Role] ([id], [createdAt], [updatedAt], [isDeleted], [name]) VALUES (3, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, N'User')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [createdAt], [updatedAt], [isDeleted], [username], [password], [roleId]) VALUES (1, CAST(N'2020-02-12T03:58:51.3668074' AS DateTime2), NULL, 0, N'admin', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1)
INSERT [dbo].[User] ([id], [createdAt], [updatedAt], [isDeleted], [username], [password], [roleId]) VALUES (4, CAST(N'2020-02-12T18:12:00.0000000' AS DateTime2), NULL, 0, N'editor', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 2)
INSERT [dbo].[User] ([id], [createdAt], [updatedAt], [isDeleted], [username], [password], [roleId]) VALUES (5, CAST(N'2020-02-12T18:13:00.0000000' AS DateTime2), NULL, 0, N'user', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[SystemAction] ON 

INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (1, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'article', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (2, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'article', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (3, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'article', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (4, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'article', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (5, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'comment', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (6, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'comment', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (7, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'comment', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (8, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'comment', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (9, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'role', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (10, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'role', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (11, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'role', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (12, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'role', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (13, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'rolesystemaction', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (14, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'rolesystemaction', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (15, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'rolesystemaction', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (16, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'rolesystemaction', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (17, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'systemaction', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (18, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'systemaction', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (19, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'systemaction', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (20, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'systemaction', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (21, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'user', N'get')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (22, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'user', N'post')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (23, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'user', N'patch')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (24, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'user', N'delete')
INSERT [dbo].[SystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [controllerName], [actionName]) VALUES (25, CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), NULL, 0, N'article', N'search')
SET IDENTITY_INSERT [dbo].[SystemAction] OFF
SET IDENTITY_INSERT [dbo].[RoleSystemAction] ON 

INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (1, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 1)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (2, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 2)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (3, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 3)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (4, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 4)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (5, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 5)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (6, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 6)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (7, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 7)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (8, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 8)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (9, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 9)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (10, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 10)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (11, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 11)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (12, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 12)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (13, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 13)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (14, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 14)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (15, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 15)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (16, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 16)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (17, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 17)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (18, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 18)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (19, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 19)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (20, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 20)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (21, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 21)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (22, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 22)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (23, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 23)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (24, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 24)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (25, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 1)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (26, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 2)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (27, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 3)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (28, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 4)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (29, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 5)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (30, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 6)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (31, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 7)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (32, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 8)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (33, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 5)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (34, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 6)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (35, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 7)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (36, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 8)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (37, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 1)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (38, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 1, 25)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (39, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 2, 25)
INSERT [dbo].[RoleSystemAction] ([id], [createdAt], [updatedAt], [isDeleted], [roleId], [systemActionId]) VALUES (40, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2), NULL, 0, 3, 25)
SET IDENTITY_INSERT [dbo].[RoleSystemAction] OFF
