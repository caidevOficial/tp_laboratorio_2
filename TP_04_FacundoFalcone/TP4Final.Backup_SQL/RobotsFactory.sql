/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
-- Tables
USE [TPFinal]
GO
    /****** Object:  Table [dbo].[Robots]    Script Date: 26/6/2021 00:24:28 ******/
    IF EXISTS (
        SELECT
            *
        FROM
            sys.objects
        WHERE
            object_id = OBJECT_ID(N'[dbo].[Robots]')
            AND type in (N'U')
    ) DROP TABLE [dbo].[Robots]
GO
    /****** Object:  Table [dbo].[Robots]    Script Date: 26/6/2021 00:24:28 ******/
SET
    ANSI_NULLS ON
GO
SET
    QUOTED_IDENTIFIER ON
GO
    CREATE TABLE [dbo].[Robots] (
        [SerialNumber] [int] NOT NULL,
        [Origin] [varchar](50) NULL,
        [ModelName] [varchar](50) NULL,
        [IsRideable] [tinyint] NOT NULL,
        CONSTRAINT [PK_Robots] PRIMARY KEY CLUSTERED ([SerialNumber] ASC) WITH (
            PAD_INDEX = OFF,
            STATISTICS_NORECOMPUTE = OFF,
            IGNORE_DUP_KEY = OFF,
            ALLOW_ROW_LOCKS = ON,
            ALLOW_PAGE_LOCKS = ON,
            OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
        ) ON [PRIMARY]
    ) ON [PRIMARY]
GO
ALTER TABLE
    [dbo].[RobotPieces] DROP CONSTRAINT [FK_RobotPieces_Robots]
GO
    /****** Object:  Table [dbo].[RobotPieces]    Script Date: 26/6/2021 00:23:55 ******/
    IF EXISTS (
        SELECT
            *
        FROM
            sys.objects
        WHERE
            object_id = OBJECT_ID(N'[dbo].[RobotPieces]')
            AND type in (N'U')
    ) DROP TABLE [dbo].[RobotPieces]
GO
    /****** Object:  Table [dbo].[RobotPieces]    Script Date: 26/6/2021 00:23:55 ******/
SET
    ANSI_NULLS ON
GO
SET
    QUOTED_IDENTIFIER ON
GO
    CREATE TABLE [dbo].[RobotPieces] (
        [id] [int] IDENTITY(1, 1) NOT NULL,
        [PieceType] [varchar](50) NULL,
        [MetalType] [varchar](50) NULL,
        [Material] [varchar](50) NULL,
        [AssociatedRobot_serial] [int] NOT NULL,
        CONSTRAINT [PK_RobotPieces] PRIMARY KEY CLUSTERED ([id] ASC) WITH (
            PAD_INDEX = OFF,
            STATISTICS_NORECOMPUTE = OFF,
            IGNORE_DUP_KEY = OFF,
            ALLOW_ROW_LOCKS = ON,
            ALLOW_PAGE_LOCKS = ON,
            OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
        ) ON [PRIMARY]
    ) ON [PRIMARY]
GO
ALTER TABLE
    [dbo].[RobotPieces] WITH CHECK
ADD
    CONSTRAINT [FK_RobotPieces_Robots] FOREIGN KEY([AssociatedRobot_serial]) REFERENCES [dbo].[Robots] ([SerialNumber])
GO
ALTER TABLE
    [dbo].[RobotPieces] CHECK CONSTRAINT [FK_RobotPieces_Robots]
GO
ALTER TABLE
    [dbo].[MaterialBuckets] DROP CONSTRAINT [FK_MaterialBuckets_Robots]
GO
    /****** Object:  Table [dbo].[MaterialBuckets]    Script Date: 26/6/2021 00:23:04 ******/
    IF EXISTS (
        SELECT
            *
        FROM
            sys.objects
        WHERE
            object_id = OBJECT_ID(N'[dbo].[MaterialBuckets]')
            AND type in (N'U')
    ) DROP TABLE [dbo].[MaterialBuckets]
GO
    /****** Object:  Table [dbo].[MaterialBuckets]    Script Date: 26/6/2021 00:23:04 ******/
SET
    ANSI_NULLS ON
GO
SET
    QUOTED_IDENTIFIER ON
GO
    CREATE TABLE [dbo].[MaterialBuckets] (
        [id] [int] IDENTITY(1, 1) NOT NULL,
        [Material_Name] [varchar](50) NULL,
        [Material_Amount] [int] NOT NULL,
        [AssociatedRobot_Serial] [int] NOT NULL,
        CONSTRAINT [PK_MaterialBuckets] PRIMARY KEY CLUSTERED ([id] ASC) WITH (
            PAD_INDEX = OFF,
            STATISTICS_NORECOMPUTE = OFF,
            IGNORE_DUP_KEY = OFF,
            ALLOW_ROW_LOCKS = ON,
            ALLOW_PAGE_LOCKS = ON,
            OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
        ) ON [PRIMARY]
    ) ON [PRIMARY]
GO
ALTER TABLE
    [dbo].[MaterialBuckets] WITH CHECK
ADD
    CONSTRAINT [FK_MaterialBuckets_Robots] FOREIGN KEY([AssociatedRobot_Serial]) REFERENCES [dbo].[Robots] ([SerialNumber])
GO
ALTER TABLE
    [dbo].[MaterialBuckets] CHECK CONSTRAINT [FK_MaterialBuckets_Robots]
GO
    -- SOME QUERYS
    -- 1
SELECT
    R.SerialNumber AS Serial,
    R.ModelName AS Model
FROM
    Robots AS R
ORDER BY
    Serial ASC;

-- 2
SELECT
    R.SerialNumber AS Serial,
    R.ModelName AS Model
FROM
    Robots AS R
GROUP BY
    R.SerialNumber,
    R.ModelName;

-- 3
SELECT
    R.ModelName AS Model,
    COUNT(R.ModelName) AS Amount
FROM
    Robots AS R
GROUP BY
    R.ModelName
ORDER BY
    Amount ASC;

-- 4
SELECT
    *
FROM
    Robots AS R
    INNER JOIN RobotPieces AS RP ON RP.AssociatedRobot_serial = R.SerialNumber
    INNER JOIN MaterialBuckets AS MB ON MB.AssociatedRobot_serial = R.SerialNumber
ORDER BY
    R.SerialNumber ASC;

-- 5
SELECT
    *
FROM
    Robots AS R,
    RobotPieces AS RP
WHERE
    RP.AssociatedRobot_serial = R.SerialNumber
ORDER BY
    R.SerialNumber ASC;

-- 6
SELECT
    *
FROM
    Robots AS R,
    RobotPieces AS RP
WHERE
    RP.AssociatedRobot_serial = R.SerialNumber
    AND RP.MetalType = 'RealSteel'
ORDER BY
    R.SerialNumber ASC;

-- 7
SELECT
    R.ModelName AS Model,
    MB.Material_Name AS Material,
    SUM(MB.Material_Amount) as mAmount
FROM
    Robots AS R
    INNER JOIN MaterialBuckets AS MB ON R.SerialNumber = MB.AssociatedRobot_Serial
GROUP BY
    R.ModelName,
    MB.Material_Name
ORDER BY
    Model ASC;

-- 8
SELECT
    R.ModelName as Model,
    COUNT(RP.AssociatedRobot_serial) AS Amount_Pieces
FROM
    Robots AS R
    INNER JOIN RobotPieces AS RP ON RP.AssociatedRobot_serial = R.SerialNumber
GROUP BY
    R.SerialNumber,
    R.ModelName
ORDER BY
    Model;