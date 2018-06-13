﻿CREATE TABLE [dbo].[User](
	[UserId] BIGINT IDENTITY(1,1) NOT NULL,
	[Firstname] NVARCHAR(50) NOT NULL,
	[Lastname] NVARCHAR(50) NOT NULL,
	[Username] NVARCHAR(50) NOT NULL,
	[ts] ROWVERSION NOT NULL,
	CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);