CREATE TABLE [dbo].[Cars] (
    [CarId]           INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]      INT           NOT NULL,
    [ColorId]      INT           NOT NULL,
    [ModelYear]    INT           NOT NULL,
    [DailyPrice]   DECIMAL (18)  NOT NULL,
    [Descriptions] VARCHAR (400) NOT NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]),
    FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId])
);