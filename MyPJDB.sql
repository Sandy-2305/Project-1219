USE [master]
GO
/****** Object:  Database [MyPJDB]    Script Date: 2022/12/16 上午 10:06:08 ******/
CREATE DATABASE [MyPJDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyPJDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyPJDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyPJDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyPJDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyPJDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyPJDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyPJDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyPJDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyPJDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyPJDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyPJDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyPJDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyPJDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyPJDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyPJDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyPJDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyPJDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyPJDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyPJDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyPJDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyPJDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyPJDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyPJDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyPJDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyPJDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyPJDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyPJDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyPJDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyPJDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MyPJDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyPJDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyPJDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyPJDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyPJDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyPJDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyPJDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyPJDB', N'ON'
GO
ALTER DATABASE [MyPJDB] SET QUERY_STORE = OFF
GO
USE [MyPJDB]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2022/12/16 上午 10:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[生日] [date] NULL,
	[Point] [int] NULL,
	[Password] [nvarchar](50) NULL,
	[權限] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderList]    Script Date: 2022/12/16 上午 10:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderList](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[訂購人] [nvarchar](50) NULL,
	[品項名稱] [nvarchar](50) NULL,
	[單價] [int] NULL,
	[購買數量] [int] NULL,
	[客製化需求] [nvarchar](max) NULL,
	[購物袋] [bit] NULL,
	[外帶] [bit] NULL,
	[總金額] [int] NULL,
	[訂購日期] [date] NULL,
 CONSTRAINT [PK_OrderList] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2022/12/16 上午 10:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[ProductPrice] [int] NULL,
	[ProductInfo] [nvarchar](200) NULL,
	[ProductImage] [nvarchar](100) NULL,
	[ProductType] [nvarchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (1, N'王小明', N'9876543210', N'台南市', N'isdidf@fjdifjs.com', CAST(N'1999-01-01' AS Date), 100, N'1234', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (3, N'李小二', N'0926373919', N'高雄市', N'linfsfsfd@fdss.com', CAST(N'1989-12-13' AS Date), 300, N'3456', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (4, N'管理者', N'1', N'台中市', N'iefiosgs@sfs.com', CAST(N'1995-10-11' AS Date), 100, N'1', 10)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (6, N'林小貓', N'0975666321', N'新北市', N'dadhadj@ajdjaosd.cpm', CAST(N'1975-11-06' AS Date), 400, N'9456', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (7, N'蔡阿武', N'0985666321', N'新竹縣', N'fdsfsfd@dsff.cpm', CAST(N'1965-07-07' AS Date), 300, N'1235', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (8, N'張大貓', N'0947893215', N'彰化縣', N'ds@sf.com', CAST(N'1979-09-06' AS Date), 600, N'4569', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (9, N'陳怡婷', N'0615454545', N'雲林縣', N'484646@xv.com', CAST(N'2004-01-15' AS Date), 500, N'1324', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (10, N'林怡君', N'0946456445', N'桃園市', N'dfgf@4554.com.tw', CAST(N'1991-04-30' AS Date), 400, N'7894', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (11, N'陳小豪', N'0952111345', N'新竹市', N'12@gdfgd.cd', CAST(N'2002-01-30' AS Date), 0, N'121213', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (18, N'一二三', N'0875666214', N'台南市', N'165454@15155.151', CAST(N'2008-12-29' AS Date), 0, N'468464', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (19, N'顧客測試', N'2', N'桃園市', N'12321@4554.1321', CAST(N'2022-12-15' AS Date), 0, N'2', 1)
INSERT [dbo].[Customers] ([ID], [姓名], [電話], [地址], [Email], [生日], [Point], [Password], [權限]) VALUES (20, N'王小名', N'0312555965', N'高雄市', N'13211@121.com', CAST(N'1933-10-31' AS Date), 0, N'0000000', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderList] ON 

INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1021, N'管理者', N'杯子蛋糕', 60, 5, N'', 0, 0, 300, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1022, N'管理者', N'鬆餅', 70, 1, N'', 1, 1, 72, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1023, N'管理者', N'熱巧克力', 50, 1, N'少糖少冰', 0, 0, 50, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1024, N'管理者', N'糖果', 50, 1, N'', 0, 0, 50, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1025, N'管理者', N'冰咖啡', 80, 1, N'半糖少冰', 1, 1, 80, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1026, N'管理者', N'鮮乳', 60, 1, N'正常正常', 0, 0, 60, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1027, N'管理者', N'鮮乳', 60, 1, N'少糖微冰', 0, 0, 60, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1028, N'管理者', N'拿鐵', 90, 1, N'', 0, 0, 90, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1029, N'管理者', N'熱巧克力', 50, 1, N'少糖少冰', 0, 0, 50, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1030, N'管理者', N'鬆餅', 70, 2, N'', 0, 0, 140, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1031, N'管理者', N'杯子蛋糕', 60, 1, N'', 0, 0, 60, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1032, N'管理者', N'糖果', 50, 1, N'', 1, 0, 52, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1033, N'管理者', N'冰咖啡', 80, 2, N'微糖少冰', 1, 0, 162, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1034, N'管理者', N'杯子蛋糕', 60, 3, N'', 0, 0, 180, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1036, N'管理者', N'杯子蛋糕', 60, 9, N'', 0, 0, 540, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (1037, N'管理者', N'鮮乳', 60, 1, N'', 0, 0, 60, CAST(N'2022-12-13' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (2004, N'管理者', N'冰咖啡', 80, 3, N'半糖去冰', 1, 0, 242, CAST(N'2022-12-14' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (2005, N'王小明', N'巧克力餅乾', 50, 3, N'', 1, 0, 152, CAST(N'2022-12-15' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (2006, N'顧客測試', N'馬卡龍', 50, 4, N'', 1, 1, 200, CAST(N'2022-12-15' AS Date))
INSERT [dbo].[OrderList] ([OrderID], [訂購人], [品項名稱], [單價], [購買數量], [客製化需求], [購物袋], [外帶], [總金額], [訂購日期]) VALUES (2007, N'管理者', N'馬卡龍', 50, 10, N'', 1, 0, 502, CAST(N'2022-12-16' AS Date))
SET IDENTITY_INSERT [dbo].[OrderList] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (1, N'糖果', 50, N'適合送禮', N'Candy.jpg', N'點心')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (2, N'巧克力餅乾', 50, N'巧克力脆片餅乾', N'ChocolateCookies.jpg', N'點心')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (3, N'杯子蛋糕', 60, N'適合搭配咖啡的點心', N'CupCake.jpg', N'點心')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (4, N'熱巧克力', 50, N'在冬天最適合來一杯熱巧克力', N'HotChocolate.jpg', N'飲品')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (5, N'冰咖啡', 80, N'冰涼的無糖咖啡', N'IceCoffee.jpg', N'飲品')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (6, N'拿鐵', 80, N'使用新鮮牛乳和濃郁咖啡', N'Latte.jpg', N'飲品')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (8, N'鮮乳', 60, N'產地直送的新鮮牛乳', N'Milk.jpg', N'飲品')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (9, N'綠茶', 80, N'無糖綠茶', N'202212071142183826.jpg', N'飲品')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (10, N'鬆餅', 70, N'現烤鬆餅加上蜂蜜和鮮奶油。', N'202212082121018540.jpg', N'點心')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (11, N'義大利麵', 100, N'現做的義大利麵', N'202212140918349551.jpg', N'點心')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductInfo], [ProductImage], [ProductType]) VALUES (12, N'馬卡龍', 50, N'好吃的甜點', N'202212160934062694.jpg', N'點心')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [MyPJDB] SET  READ_WRITE 
GO
