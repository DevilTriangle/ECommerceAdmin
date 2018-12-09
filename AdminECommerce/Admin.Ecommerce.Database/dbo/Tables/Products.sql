CREATE TABLE [dbo].[Products] (
    [Id]               VARCHAR (50)   NOT NULL,
    [Name]             NVARCHAR (50)  NOT NULL,
    [Price]            FLOAT (53)     NOT NULL,
    [CategoryID]       INT            NOT NULL,
    [Image1]           VARCHAR (50)   NOT NULL,
    [Image2]           VARCHAR (50)   NULL,
    [Image3]           VARCHAR (50)   NULL,
    [Image4]           VARCHAR (50)   NULL,
    [Manufacturer]     NVARCHAR (50)  NULL,
    [Description]      NVARCHAR (MAX) NULL,
    [ShortDescription] NVARCHAR (255) NULL,
    [OtherInfo]        NVARCHAR (255) NULL,
    [Stock]            INT            NOT NULL,
    [DateArrivals]     DATETIME       NOT NULL,
    [SaleOff]          FLOAT (53)     NULL,
    [AttVal1]          NVARCHAR (255) NULL,
    [AttVal2]          NVARCHAR (255) NULL,
    [AttVal3]          NVARCHAR (255) NULL,
    [AttVal4]          NVARCHAR (255) NULL,
    [AttVal5]          NVARCHAR (255) NULL,
    [AttVal6]          NVARCHAR (255) NULL,
    [AttVal7]          NVARCHAR (255) NULL,
    [AttVal8]          NVARCHAR (255) NULL,
    [AttVal9]          NVARCHAR (255) NULL,
    [AttVal10]         NVARCHAR (255) NULL,
    [RatingScore]      INT            NULL,
    [NumOfRates]       INT            NULL,
    [IsActive]         BIT            NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Products_dbo.Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryID]
    ON [dbo].[Products]([CategoryID] ASC);

