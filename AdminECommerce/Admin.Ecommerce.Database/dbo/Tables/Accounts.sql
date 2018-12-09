CREATE TABLE [dbo].[Accounts] (
    [Id]        VARCHAR (50)   NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    [Email]     VARCHAR (50)   NOT NULL,
    [Phone]     VARCHAR (50)   NULL,
    [Password]  VARCHAR (100)  NOT NULL,
    [Address]   NVARCHAR (MAX) NULL,
    [Image]     VARCHAR (50)   NULL,
    [RoleID]    NVARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_dbo.Accounts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Accounts_dbo.Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles] ([ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_RoleID]
    ON [dbo].[Accounts]([RoleID] ASC);

