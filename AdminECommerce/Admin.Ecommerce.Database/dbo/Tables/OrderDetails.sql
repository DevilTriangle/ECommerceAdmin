CREATE TABLE [dbo].[OrderDetails] (
    [OrderID]   VARCHAR (50) NOT NULL,
    [ProductID] VARCHAR (50) NOT NULL,
    [Quantity]  INT          NOT NULL,
    [Price]     FLOAT (53)   NOT NULL,
    [SaleOff]   FLOAT (53)   NOT NULL,
    [Image]     VARCHAR (50) NULL,
    [Color]     VARCHAR (50) NULL,
    CONSTRAINT [PK_dbo.OrderDetails] PRIMARY KEY CLUSTERED ([OrderID] ASC, [ProductID] ASC),
    CONSTRAINT [FK_dbo.OrderDetails_dbo.Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([ID]),
    CONSTRAINT [FK_dbo.OrderDetails_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([Id])
);




GO
CREATE NONCLUSTERED INDEX [IX_OrderID]
    ON [dbo].[OrderDetails]([OrderID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductID]
    ON [dbo].[OrderDetails]([ProductID] ASC);

