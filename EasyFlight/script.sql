USE [EasyFlight]
GO
/****** Object:  Table [dbo].[AdditionalServiceAirline]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdditionalServiceAirline](
	[Id] [uniqueidentifier] NOT NULL,
	[AirlineId] [uniqueidentifier] NOT NULL,
	[HandBaggage] [nvarchar](max) NOT NULL,
	[CheckedBaggage] [nvarchar](max) NOT NULL,
	[Drink] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AdditionalServiceAirline] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Airline]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airline](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_Airline] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AirlineDestination]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirlineDestination](
	[Id] [uniqueidentifier] NOT NULL,
	[DestinationId] [uniqueidentifier] NOT NULL,
	[AirlineId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AirlineDestination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Airplane]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airplane](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Airplane] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Destination]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destination](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Destination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Flight]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flight](
	[Id] [uniqueidentifier] NOT NULL,
	[AirlineId] [uniqueidentifier] NOT NULL,
	[DestinationIdFrom] [uniqueidentifier] NOT NULL,
	[DestinationIdTo] [uniqueidentifier] NOT NULL,
	[AirplainId] [uniqueidentifier] NOT NULL,
	[TypeId] [uniqueidentifier] NOT NULL,
	[Distance] [nvarchar](50) NOT NULL,
	[DateAndTimeOfDeparture] [datetime] NOT NULL,
	[DateAndTimeOfLanding] [datetime] NOT NULL,
	[TimeOfTrevel] [time](7) NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Friend]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Friend](
	[Id] [uniqueidentifier] NOT NULL,
	[UserSendId] [uniqueidentifier] NOT NULL,
	[UserReceivedId] [uniqueidentifier] NOT NULL,
	[Accepted] [bit] NULL,
 CONSTRAINT [PK_Friend] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[Id] [uniqueidentifier] NOT NULL,
	[DestinationId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rating]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[FlightId] [uniqueidentifier] NOT NULL,
	[AirlineId] [uniqueidentifier] NOT NULL,
	[Mark] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentaCar]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentaCar](
	[Id] [uniqueidentifier] NOT NULL,
	[DestinationId] [uniqueidentifier] NOT NULL,
	[Car] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Id] [uniqueidentifier] NOT NULL,
	[FlightId] [uniqueidentifier] NOT NULL,
	[SeatId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[PassportSerialNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seat]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat](
	[Id] [uniqueidentifier] NOT NULL,
	[AirplaneId] [uniqueidentifier] NOT NULL,
	[TypeId] [uniqueidentifier] NOT NULL,
	[ColumnNumber] [nvarchar](10) NOT NULL,
	[RowNumber] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Seat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SeatInfo]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeatInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[SeatId] [uniqueidentifier] NOT NULL,
	[FlightId] [uniqueidentifier] NOT NULL,
	[DiscountPrice] [money] NULL,
 CONSTRAINT [PK_SeatInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeOfFlight]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfFlight](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfFlight] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeOfSeat]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfSeat](
	[Id] [uniqueidentifier] NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfSeat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 9/11/2019 7:06:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[AirlineId] [uniqueidentifier] NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](25) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[AdditionalServiceAirline] ([Id], [AirlineId], [HandBaggage], [CheckedBaggage], [Drink]) VALUES (N'cebbb2ca-c72e-4a10-85db-2c91d2c147da', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'U avion možete potpuno besplatno da unesete jedan komad ručnog prtljaga, bilo da je to ranac, mala torba ili kofer. Vaš ručni prtljag će biti obeležen plavim priveskom, a nakon ukrcavanja je potrebno da ga smestite u odeljak za prtljag iznad svog sedišta. Važno je samo da ne prelazi dozvoljenu težinu i dimenzije. Za Ekonomsku klasnu maksimalana tezina prtljaga iznosi 8kg i dimenzije kofera ne smiju prelaziti 40x23x55 (Duzina x Sirina x Visina)', N'Sve što želite da ponesete na putovanje, a ne može da stane u vaš ručni prtljag, spakujte i predajte na aerodromu. Dozvoljena težina predatog prtljaga zavisi od toga gde putujete, klase i tarife kojom letite, kao i vašeg članstva u Etihad Guest programu.', N'Uz kupljenu kartu gratis jedno pice po izboru. Svako naredno pice se naplacuje.')
INSERT [dbo].[Airline] ([Id], [Name], [Address], [Description], [Rating]) VALUES (N'15fc26d6-5a5c-4ab6-a9c6-3368ebc72d9e', N'Croatia Airlines', N'Zagreb', N'dasdsadadasdasd', 4)
INSERT [dbo].[Airline] ([Id], [Name], [Address], [Description], [Rating]) VALUES (N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'Air Serbia', N'Beograd', N'Rezervišite kartu na zvaničnom sajtu i putujte na destinacije širom sveta! Ne propustite nezaboravno iskustvo. 90 godina sa vama. Etihad Airways Partner. Odlične konekcije. Wi-Fly. Izbor tarifa. Kreiraj svoj let. Usluge: Odabir sedišta, Dodatni prtljag, Prioritetni prtljag, Premijum salon.', 5)
INSERT [dbo].[AirlineDestination] ([Id], [DestinationId], [AirlineId]) VALUES (N'c141a749-be02-4b60-8a9a-157142fcff6c', N'5c1cc536-a07a-4295-9b05-e923147ed605', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301')
INSERT [dbo].[AirlineDestination] ([Id], [DestinationId], [AirlineId]) VALUES (N'033a2d7c-ab85-42cf-9740-2ff24cfc3b29', N'6bbc198d-80d2-43c2-8831-bd362ed132cc', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301')
INSERT [dbo].[AirlineDestination] ([Id], [DestinationId], [AirlineId]) VALUES (N'6898cf42-b41e-4202-a548-3dbbcedecbd2', N'213da9f6-7302-41ed-957c-9f2206c49b36', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301')
INSERT [dbo].[AirlineDestination] ([Id], [DestinationId], [AirlineId]) VALUES (N'e19e98bc-543e-45be-9e02-e53008227ae6', N'62c71451-0615-48da-bdfd-62890e47605e', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301')
INSERT [dbo].[Airplane] ([Id], [Name]) VALUES (N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'boeing 777-200')
INSERT [dbo].[Airplane] ([Id], [Name]) VALUES (N'11943917-68ec-495f-a99a-a893da0f5baf', N'Boeing 777')
INSERT [dbo].[Airplane] ([Id], [Name]) VALUES (N'f7ba00d4-5065-47d0-9915-b2e1159b20c7', N'Boing 747')
INSERT [dbo].[Destination] ([Id], [Name], [Description]) VALUES (N'b5c10498-bf34-45cf-a919-08faacff682c', N'New York', N'New York je grad u istoimenoj saveznoj državi New York i najveći grad po broju stanovnika u Sjedinjenim Američkim Državama. Drugi je grad po broju stanovnika u Sjevernoj Americi. New York se nalazi u sjeveroistočnom dijelu zemlje na nekoliko poluostrva i ostrva, a sačinjen je od 5 gradskih oblasti: Manhattan (Manhatn ), Brooklyn (Bruklin), Queens (Kvins), Bronx (Bronks) i Staten Island (Stejten Ajlend )')
INSERT [dbo].[Destination] ([Id], [Name], [Description]) VALUES (N'62c71451-0615-48da-bdfd-62890e47605e', N'Beograd', N'Beograd je glavni i najveci grad republike Srbije. Nalazi se na uscu Save u Dunav, na mjestu razgranicenja jugoistocne i srednje evrope')
INSERT [dbo].[Destination] ([Id], [Name], [Description]) VALUES (N'213da9f6-7302-41ed-957c-9f2206c49b36', N'Berlin', N'Berlin  je s više od 3,5 milijuna stanovnika najveći i glavni grad Njemačke i nakon Londona drugi najveći grad Europske unije. Prije Drugog svjetskog rata imao je 4,5 milijuna stanovnika, a u vrijeme Hladnog rata od 1949. do 1990. bio je podijeljen na Istočni Berlin i Zapadni Berlin')
INSERT [dbo].[Destination] ([Id], [Name], [Description]) VALUES (N'6bbc198d-80d2-43c2-8831-bd362ed132cc', N'Singapur', N'Singapur je ostrvska grad drzavau jugoistocnoj Aziji na jugu Maleziskog poluostrva.')
INSERT [dbo].[Destination] ([Id], [Name], [Description]) VALUES (N'5c1cc536-a07a-4295-9b05-e923147ed605', N'Temišvar', N'Temišvar  ima preko 331.927 st. i najveće je naselje čitavog Banata. Grad je okružen obrađenom zemljom i jedan je od najrazvijenijh i najindustrijaliziranijih gradova u Rumunjskoj. To je prvi grad s električnim osvjetljenjem u Europi. Neke je zgrade u ovom gradu projektirao i slavni Gustave Eiffel. U Temišvaru je započela pobuna naroda protiv komunističke vlasti. Pobuna je krvavo ugušena (1 104 mrtva, 3 352 ranjena), ali je to bio početak kraja vladavine komunista koja se završila tjedan dana poslije.')
INSERT [dbo].[Flight] ([Id], [AirlineId], [DestinationIdFrom], [DestinationIdTo], [AirplainId], [TypeId], [Distance], [DateAndTimeOfDeparture], [DateAndTimeOfLanding], [TimeOfTrevel], [Price]) VALUES (N'23d6904f-83a1-43f8-8467-2709a8875d9d', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'6bbc198d-80d2-43c2-8831-bd362ed132cc', N'5c1cc536-a07a-4295-9b05-e923147ed605', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'cf92e4d8-94a1-4339-ba1d-53cbb773351f', N'1000', CAST(N'2019-09-10 00:00:00.000' AS DateTime), CAST(N'2019-09-10 00:00:00.000' AS DateTime), CAST(N'01:01:00' AS Time), 100.0000)
INSERT [dbo].[Flight] ([Id], [AirlineId], [DestinationIdFrom], [DestinationIdTo], [AirplainId], [TypeId], [Distance], [DateAndTimeOfDeparture], [DateAndTimeOfLanding], [TimeOfTrevel], [Price]) VALUES (N'b2ff40c7-b3b2-4a5f-b6cf-8a7a6d547d88', N'15fc26d6-5a5c-4ab6-a9c6-3368ebc72d9e', N'62c71451-0615-48da-bdfd-62890e47605e', N'b5c10498-bf34-45cf-a919-08faacff682c', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'8d4d0ed0-7af9-4c6f-900e-a934abe8cdf8', N'100', CAST(N'2019-08-14 00:00:00.000' AS DateTime), CAST(N'2019-08-14 00:00:00.000' AS DateTime), CAST(N'02:30:00' AS Time), 150.0000)
INSERT [dbo].[Flight] ([Id], [AirlineId], [DestinationIdFrom], [DestinationIdTo], [AirplainId], [TypeId], [Distance], [DateAndTimeOfDeparture], [DateAndTimeOfLanding], [TimeOfTrevel], [Price]) VALUES (N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'62c71451-0615-48da-bdfd-62890e47605e', N'6bbc198d-80d2-43c2-8831-bd362ed132cc', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'cf92e4d8-94a1-4339-ba1d-53cbb773351f', N'1000', CAST(N'2019-09-25 00:00:00.000' AS DateTime), CAST(N'2019-09-25 00:00:00.000' AS DateTime), CAST(N'01:01:00' AS Time), 1000.0000)
INSERT [dbo].[Flight] ([Id], [AirlineId], [DestinationIdFrom], [DestinationIdTo], [AirplainId], [TypeId], [Distance], [DateAndTimeOfDeparture], [DateAndTimeOfLanding], [TimeOfTrevel], [Price]) VALUES (N'8c6e7676-504b-4055-b3d0-df6f1d6452fb', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'62c71451-0615-48da-bdfd-62890e47605e', N'b5c10498-bf34-45cf-a919-08faacff682c', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'8d4d0ed0-7af9-4c6f-900e-a934abe8cdf8', N'100', CAST(N'2019-08-27 00:00:00.000' AS DateTime), CAST(N'2019-08-27 00:00:00.000' AS DateTime), CAST(N'03:30:00' AS Time), 500.0000)
INSERT [dbo].[Friend] ([Id], [UserSendId], [UserReceivedId], [Accepted]) VALUES (N'db380ce6-2e60-4e18-b949-904d9a487350', N'db84eddd-bd07-41c9-de8b-08d7263ddaac', N'81946fae-6be4-4254-b5f7-d43bba1e077e', 1)
INSERT [dbo].[Friend] ([Id], [UserSendId], [UserReceivedId], [Accepted]) VALUES (N'8dc3e139-7c42-4412-8630-9c5c319dad38', N'db84eddd-bd07-41c9-de8b-08d7263ddaac', N'b23a5736-6a64-4302-86cd-b9f4aedef68a', 1)
INSERT [dbo].[Friend] ([Id], [UserSendId], [UserReceivedId], [Accepted]) VALUES (N'671252eb-7c02-40bc-b6db-f518397b3801', N'c9843eb4-0153-44f4-8016-d061e0106a5e', N'db84eddd-bd07-41c9-de8b-08d7263ddaac', 1)
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'66b26a68-f3b2-4c13-9a19-5013d7e14632', N'b5c10498-bf34-45cf-a919-08faacff682c', N'Ace Hotel', N'Nalazimo se na Manhattn-u.  ')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'152f77a7-29f9-4570-bad6-e7903ab0bb62', N'b5c10498-bf34-45cf-a919-08faacff682c', N'Row Hotel', NULL)
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'64368b91-90c3-49e7-b056-6f60e74fd5e6', N'b5c10498-bf34-45cf-a919-08faacff682c', N'Cambria Hotel ', N'Times Square')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'070a6da2-4653-49ee-8102-94e8ee91332f', N'62c71451-0615-48da-bdfd-62890e47605e', N'Hotel Slavija', N'Naš hotel se odlikuje jedinstvenim arhitektonskim stilom secesije i kao takav nosi tradiciju dugu jednog veka, a posluje pod zaštitom spomenika kulture Republike Srbije.')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'bebbc36e-bbc0-45a0-bbf9-e63babf8e039', N'62c71451-0615-48da-bdfd-62890e47605e', N'Hotel Beograd', N'Naš hotel se odlikuje jedinstvenim arhitektonskim stilom secesije i kao takav nosi tradiciju dugu jednog veka, a posluje pod zaštitom spomenika kulture Republike Srbije.')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'e682ca72-968f-43fc-b75f-62d07122efac', N'213da9f6-7302-41ed-957c-9f2206c49b36', N'Hotel Berlin', N'Naš hotel se odlikuje jedinstvenim arhitektonskim stilom secesije i kao takav nosi tradiciju dugu jednog veka, a posluje pod zaštitom spomenika kulture Republike Nemacke')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'bbd9dfc9-2a2c-4be8-97b5-1ea05512353d', N'6bbc198d-80d2-43c2-8831-bd362ed132cc', N'Hotel Singapur', N'Naš hotel se odlikuje jedinstvenim arhitektonskim stilom secesije i kao takav nosi tradiciju dugu jednog veka, a posluje pod zaštitom spomenika kulture Republike.')
INSERT [dbo].[Hotel] ([Id], [DestinationId], [Name], [Description]) VALUES (N'3b2ef416-916c-4781-84f5-dea2c596d421', N'5c1cc536-a07a-4295-9b05-e923147ed605', N'Hotel Temisvar', N'Naš hotel se odlikuje jedinstvenim arhitektonskim stilom secesije i kao takav nosi tradiciju dugu jednog veka, a posluje pod zaštitom spomenika kulture Republike.')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'dc679e4f-bb27-47c4-ae22-11c3b92b9da8', N'23d6904f-83a1-43f8-8467-2709a8875d9d', N'290be1dc-3649-4a04-a500-020cf9979aa1', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'94ce7f8b-a7a0-4aef-8659-16985ce87c48', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', N'2ae29e61-ad81-4b0f-947f-99b9470e02eb', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'730ab44f-0b49-4e68-a6f9-1850e85880ee', N'23d6904f-83a1-43f8-8467-2709a8875d9d', N'9cffd07a-0182-4ff3-950b-609345134e41', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'cc4bde4f-e388-4276-b5a0-33812840bdb4', N'23d6904f-83a1-43f8-8467-2709a8875d9d', N'259f2b64-cb96-43c6-bff6-aecd691b8f37', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'ffcfcf82-2350-471f-b5b5-9754aaf48017', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', N'412b2b35-e6dd-4e0e-b4c5-6c3e8ced6168', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Reservation] ([Id], [FlightId], [SeatId], [Name], [Surname], [PassportSerialNumber]) VALUES (N'59cf2146-6d89-4c15-bda6-a9a2f819d599', N'23d6904f-83a1-43f8-8467-2709a8875d9d', N'a2afcf9f-df81-4bd2-9454-d837d89e15c9', N'Budimko', N'Ilic', N'12345678')
INSERT [dbo].[Role] ([Id], [Type]) VALUES (N'6391dfdd-a479-4ea9-bc6a-312dbd2cbbe2', N'Admin')
INSERT [dbo].[Role] ([Id], [Type]) VALUES (N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'User')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'290be1dc-3649-4a04-a500-020cf9979aa1', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'5f0e15bf-d816-4b5c-b51a-03e3fa3db933', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'cac010dc-b970-4af1-aa7c-05136e18911c', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'6ef8a01c-259b-4671-81f2-088448be8497', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'8d388ba5-f976-4051-b130-0a145f8e782f', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'f218728f-ac0c-4691-97fb-1484962b808b', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'52ec1c84-0844-4d65-bfd2-15c78ced3fc9', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'54acd66c-2547-4351-b9b8-20ed1cccc1ca', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'53f0c71f-c51c-4557-9a0e-284575cfe9e2', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'75a68de6-7ffe-494a-8151-2d1c1192b28d', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'A', N'10')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'dfcabd08-815b-43a9-ab3a-31db61af3177', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'9cac9dee-8cb1-498b-a9c0-33e9e1241f72', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'2d45c0af-e859-4817-a3a4-34edb756596b', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'7e76f359-76ed-4cb9-8448-3b0e14427b7f', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'd57bbdf2-fa77-43ad-9581-4059275a2fae', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'cd2b3f11-f875-49c4-ba57-43745a25f538', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'da78059c-2b78-42ec-9626-50f8f250be7e', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'cb2469af-8642-4ebb-bce7-5210541e4a9e', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'a060bae8-dac4-4721-b72b-570c8ad17573', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'e3d0e0cc-4394-4c8d-8a58-5aad535db531', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'B', N'10')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'9cffd07a-0182-4ff3-950b-609345134e41', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'77d16069-5784-42e4-b961-61e9063e210e', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'412b2b35-e6dd-4e0e-b4c5-6c3e8ced6168', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'5648cf6a-9f1c-43aa-96e4-6c829b34ccd1', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'1adf89a6-17dd-4c29-8de4-749bd7c49180', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'4cf7791c-a027-492a-ace3-761a2dd03cab', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'98fa4477-9e1f-495e-9195-76631a756745', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'23a68400-2f77-40b0-82e1-7803a81d57da', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'44eddf00-83ad-4773-b6ef-7b52c8def86b', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'5de16afa-06a3-4c51-86d0-7fd981362a3b', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'C', N'10')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'72535114-5ed5-44cb-9e59-82d3f060686d', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'4283974c-41b5-481e-893a-8b1bc4e8f1b9', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'7c29d7b2-c39f-427b-afc2-8c94fb3b0a60', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'854ba7b6-f8e4-4bcb-b07c-8d0199b3c488', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'56a0be13-0a94-4f86-bddc-9001774d7d94', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'86600734-fd13-47da-98a0-95977ac2159d', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'c2722380-f92a-4871-9416-9949ac5344f2', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'2ae29e61-ad81-4b0f-947f-99b9470e02eb', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'154ec4ed-1942-4b16-b47e-a2f071d03308', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'298fcb56-cd00-445e-ad5b-a400e75e61a9', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'D', N'10')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'259f2b64-cb96-43c6-bff6-aecd691b8f37', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'3050f506-e8d5-4da9-ac18-bb5f68e215e5', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'94d58580-2957-4d07-8a5e-bbf61bd2cc63', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'e15e7944-d15a-4d91-87aa-bc1b42ba0e44', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'503e49e5-4b77-40dc-9676-c0b94488862e', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'bca2252e-c69e-4ef8-ab6d-cc56567f45a3', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'd91e099f-5886-4cea-a157-cc79af383c63', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'3be5f94e-8bb7-46d4-a576-d41deea84edf', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'a86a7918-eb38-4776-8127-d50ee1d059ad', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'f1e3eb09-6b2e-42b9-9e00-d6621abf194c', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'E', N'10')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'a2afcf9f-df81-4bd2-9454-d837d89e15c9', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'1')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'eccf396e-069e-4ebc-b4eb-d9bc3c3fe558', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'2')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'8a546da0-9e0a-4ae7-a2fd-dc50e68a29d7', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'3')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'6c0b7112-ec9a-42d9-b7af-de54b91fd7d3', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'4')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'57632cc1-ddc8-4ca8-b2ae-e8f32665beac', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'5')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'0d9c34e7-5a9e-447e-a063-e9744bc4b7d0', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'6')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'93907a42-98f8-41e5-ad83-ee37243ef9a6', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'7')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'd3aa47ae-7fa3-4176-b675-eecc26a28b88', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'8')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'ed82695c-b32f-497b-bab4-f0f1f4fe137b', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'F', N'9')
INSERT [dbo].[Seat] ([Id], [AirplaneId], [TypeId], [ColumnNumber], [RowNumber]) VALUES (N'0756db6c-d9c2-4270-9342-f8edc1b41345', N'320f2833-58c2-49e8-8da1-1ef29c47cf5b', N'ed44f3c7-0271-448e-9445-2806f544061c', N'9', N'10')
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'0ddb8eb0-25a2-4239-b246-0aabae95540e', N'dfcabd08-815b-43a9-ab3a-31db61af3177', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'efdef1d8-9e02-4a76-ab75-0f500dd9ff43', N'56a0be13-0a94-4f86-bddc-9001774d7d94', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'fe4c5c50-054f-4b75-882b-14531f5c66d8', N'86600734-fd13-47da-98a0-95977ac2159d', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'4ae258ea-299e-4ed8-8f31-1988413699f2', N'cac010dc-b970-4af1-aa7c-05136e18911c', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'0b17dd29-8817-406f-90e0-19ca75bf874d', N'0756db6c-d9c2-4270-9342-f8edc1b41345', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'b668e67e-7eb7-4226-9d0d-1a87cd98cbea', N'9cac9dee-8cb1-498b-a9c0-33e9e1241f72', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'c9981b2e-b1e3-47be-a46a-208dbd74d031', N'da78059c-2b78-42ec-9626-50f8f250be7e', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'70b4e497-f9cb-4de9-bc9c-25c5337dc945', N'f218728f-ac0c-4691-97fb-1484962b808b', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'a242ee52-c937-4014-becb-277ce5e55ab6', N'77d16069-5784-42e4-b961-61e9063e210e', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'def399fd-7dec-4b7d-a4d9-2bb6ff5d56ce', N'e3d0e0cc-4394-4c8d-8a58-5aad535db531', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'ae7705a7-92f7-42f4-a33b-2c0aa955bbb2', N'ed82695c-b32f-497b-bab4-f0f1f4fe137b', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'9c6b6fdb-8a69-4a2d-99aa-307cb67738ab', N'a86a7918-eb38-4776-8127-d50ee1d059ad', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'5f5281d9-085b-49b6-ad03-337b6210f5d3', N'75a68de6-7ffe-494a-8151-2d1c1192b28d', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'2977934e-9405-4b6b-ba32-34a170ef73ad', N'bca2252e-c69e-4ef8-ab6d-cc56567f45a3', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'616ab99f-25b3-40b9-9486-3e1d0a0be7e8', N'2d45c0af-e859-4817-a3a4-34edb756596b', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'5f977045-72ce-4fc0-9181-3ec171a2ca76', N'e15e7944-d15a-4d91-87aa-bc1b42ba0e44', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'9c9aea32-8247-49b5-8bdf-4402870bc145', N'c2722380-f92a-4871-9416-9949ac5344f2', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'b2684049-a2a3-44a7-8682-4465e7d7859b', N'54acd66c-2547-4351-b9b8-20ed1cccc1ca', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'8a4138f2-26fe-41cd-bbfb-4538bafef897', N'53f0c71f-c51c-4557-9a0e-284575cfe9e2', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'f7479d9b-1972-4f25-ad1f-4eae708c3cf9', N'44eddf00-83ad-4773-b6ef-7b52c8def86b', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'9351a2a4-aec8-4119-9ec0-4ec16f74ffd8', N'154ec4ed-1942-4b16-b47e-a2f071d03308', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'1bd20aab-ef12-4f88-b89b-536a14d55461', N'854ba7b6-f8e4-4bcb-b07c-8d0199b3c488', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'08003e32-5bcd-4436-9e86-56f56ab5e766', N'52ec1c84-0844-4d65-bfd2-15c78ced3fc9', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'ecc5dddb-3df1-4442-9040-594489aa6eeb', N'5648cf6a-9f1c-43aa-96e4-6c829b34ccd1', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'56e8dfc1-194a-4c20-b61a-5a89ff951e5f', N'5f0e15bf-d816-4b5c-b51a-03e3fa3db933', N'8c6e7676-504b-4055-b3d0-df6f1d6452fb', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'31da5774-377b-4b45-8bbc-5ade1336fd56', N'503e49e5-4b77-40dc-9676-c0b94488862e', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'b62c96ab-ba73-4ca5-9004-5d2f7361d5bc', N'5de16afa-06a3-4c51-86d0-7fd981362a3b', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'a7938815-666e-4f79-bb2b-616f5aba037e', N'2ae29e61-ad81-4b0f-947f-99b9470e02eb', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'7656be2b-68c1-4d09-b25d-6c5a97e4d7f4', N'9cffd07a-0182-4ff3-950b-609345134e41', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'fb8031d4-b70f-4854-afde-7b7cadaabad2', N'53f0c71f-c51c-4557-9a0e-284575cfe9e2', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'02d486e2-7788-4dc9-82db-82e693a3352d', N'7c29d7b2-c39f-427b-afc2-8c94fb3b0a60', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'16e6024d-4412-4f95-a06d-862b0c3ba784', N'23a68400-2f77-40b0-82e1-7803a81d57da', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'08b09e7c-219a-4e04-b0b3-86dd54a8813a', N'6ef8a01c-259b-4671-81f2-088448be8497', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'15cac58b-a344-4e6d-9d3f-8df005b9fa23', N'72535114-5ed5-44cb-9e59-82d3f060686d', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'e5dc6a4d-20e1-4d66-b43b-8f9b3a6ba734', N'98fa4477-9e1f-495e-9195-76631a756745', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'f674bf66-80df-4e1f-9096-9953445d3011', N'94d58580-2957-4d07-8a5e-bbf61bd2cc63', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'e9226fe4-b3b3-41f0-a736-9b6f66547da3', N'0d9c34e7-5a9e-447e-a063-e9744bc4b7d0', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'dc94f99c-cccb-4576-95a8-9c19a8b01bc9', N'412b2b35-e6dd-4e0e-b4c5-6c3e8ced6168', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'f8a87db5-b02d-4af7-b30f-acfb7d92d4ed', N'cb2469af-8642-4ebb-bce7-5210541e4a9e', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'98750955-abc7-4fda-bd39-afc1968d25a3', N'298fcb56-cd00-445e-ad5b-a400e75e61a9', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'7cbb21d3-9865-492d-bc98-afec206bfea4', N'd3aa47ae-7fa3-4176-b675-eecc26a28b88', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'5a2a94b5-2903-4ac6-bc6f-b09e441df77f', N'8a546da0-9e0a-4ae7-a2fd-dc50e68a29d7', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'32161901-3e27-4cab-abf4-b0d2818b12f8', N'52ec1c84-0844-4d65-bfd2-15c78ced3fc9', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'8ed64b14-8a11-465f-b8fd-b4d90f8ee0c0', N'5f0e15bf-d816-4b5c-b51a-03e3fa3db933', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'38049293-b853-43a0-a8d7-b5f373bb0550', N'a2afcf9f-df81-4bd2-9454-d837d89e15c9', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'31d7092b-e73a-445b-9af7-b656d30bba36', N'eccf396e-069e-4ebc-b4eb-d9bc3c3fe558', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'4a2baa82-edfe-4dd8-b5c5-b672688988f1', N'4283974c-41b5-481e-893a-8b1bc4e8f1b9', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'e35ab959-0753-48d1-8357-b9729a5c7311', N'1adf89a6-17dd-4c29-8de4-749bd7c49180', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'41f8cff3-51cf-4a46-91ad-ba72e2ff4b63', N'290be1dc-3649-4a04-a500-020cf9979aa1', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'06c9246d-ef9a-47d8-bda6-bcfdf498d909', N'a060bae8-dac4-4721-b72b-570c8ad17573', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'e8a16565-7814-4ec1-9ae0-bdbab4dcf74f', N'259f2b64-cb96-43c6-bff6-aecd691b8f37', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'5ad586cd-1829-4996-b8da-c1e767491447', N'93907a42-98f8-41e5-ad83-ee37243ef9a6', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'01fbf64a-c37d-494d-91a2-c424cf702105', N'4cf7791c-a027-492a-ace3-761a2dd03cab', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'135e764f-aab4-4a4a-ba58-c4994feef2b0', N'6c0b7112-ec9a-42d9-b7af-de54b91fd7d3', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'fc6a9fb0-ee6d-4624-ade1-c50d2c2622e3', N'57632cc1-ddc8-4ca8-b2ae-e8f32665beac', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'733502e4-743c-4767-8ab0-cad1558de001', N'1adf89a6-17dd-4c29-8de4-749bd7c49180', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'9bc66c33-0e05-45af-9af5-cadb9504589d', N'f1e3eb09-6b2e-42b9-9e00-d6621abf194c', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'642624cb-adac-4fa4-a6d1-d5396c8cdf15', N'e3d0e0cc-4394-4c8d-8a58-5aad535db531', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'c11da218-f140-429d-9431-dee8af8a203f', N'cd2b3f11-f875-49c4-ba57-43745a25f538', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'e7406de3-b90a-43a9-a59d-dfdf1aa61b36', N'd91e099f-5886-4cea-a157-cc79af383c63', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'54ad9a5a-c426-4b47-a96c-f3544737915c', N'8d388ba5-f976-4051-b130-0a145f8e782f', N'23d6904f-83a1-43f8-8467-2709a8875d9d', NULL)
INSERT [dbo].[SeatInfo] ([Id], [SeatId], [FlightId], [DiscountPrice]) VALUES (N'd4083bd4-5267-48c1-8351-fe9504ce00c0', N'3050f506-e8d5-4da9-ac18-bb5f68e215e5', N'd7fa7543-2de4-4e2a-8518-d3cfa4d5ef7f', NULL)
INSERT [dbo].[TypeOfFlight] ([Id], [Type]) VALUES (N'cf92e4d8-94a1-4339-ba1d-53cbb773351f', N'Round Trup')
INSERT [dbo].[TypeOfFlight] ([Id], [Type]) VALUES (N'8d4d0ed0-7af9-4c6f-900e-a934abe8cdf8', N'One Wey')
INSERT [dbo].[TypeOfFlight] ([Id], [Type]) VALUES (N'0ae41c8a-5e36-4185-9c2f-edd67f918c81', N'Multi City')
INSERT [dbo].[TypeOfSeat] ([Id], [Class]) VALUES (N'ed44f3c7-0271-448e-9445-2806f544061c', N'First')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'db84eddd-bd07-41c9-de8b-08d7263ddaac', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'Budimko', N'Ilic', N'qq@gmail.com', N'qq', N'Kornelija Stankovica 35', N'0649573720')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'14b532ea-ee5d-47d6-8982-167b50ff828c', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'Budimko', N'Ilic', N'mb992@live.com', N'papanijotija', N'asdf', N'1')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'5c825bc9-737f-4705-a2a4-4709bd3a735b', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'2', N'2', N'2@gmail.com', N'2', N'2', N'2')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'd4170ecc-510e-48af-b3b1-5cc5ee2464da', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'sdsadasd', N'1', N'm@dsds', N'1', N'1', N'1')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'e2ffdff9-5fc9-43bb-810f-5e0f8d34dd81', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'novi', N'korisnik', N'novi@gmail.com', N'nn', N'nn', N'1')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'57a17fc4-cec2-4b14-96db-6af5a1909ca8', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'sdsadasd', N'q', N'm@dsds.nrma', N'qq', N'eweefr', N'sfsfs')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'492672af-903c-4579-ad48-6c3956533cd2', N'8f4c4ce7-4056-4fd4-8f13-7f7d1d65b301', N'6391dfdd-a479-4ea9-bc6a-312dbd2cbbe2', N'Glavni', N'Baja', N'glavni@gmail.com', N'qq', N'BB', N'BB')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'07962465-e0da-43d9-a53c-7fdf5eb1cc04', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'bb', N'bb', N'bb@gmail.com', N'bb', N'bb', N'bb')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'b23a5736-6a64-4302-86cd-b9f4aedef68a', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'11', N'11', N'11@gmail.com', N'11', N'11', N'11')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'c9843eb4-0153-44f4-8016-d061e0106a5e', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'Toba', N'Tobic', N'mb@gmail.com', N'mb', N'Ns', N'1')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'81946fae-6be4-4254-b5f7-d43bba1e077e', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'r', N'r', N'test1@gmail.com', N'r', N'r', N'1')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'f2a11505-69ce-43ff-b2eb-d7ffd8153d3f', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'ILC', N'ilc', N'ilc@ilc.ilc', N'qawsed1', N'Kocesvoje', N'Nemoram ako hocu')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'87a2ef99-b0f0-407f-9df5-d87bd3240c51', NULL, N'6391dfdd-a479-4ea9-bc6a-312dbd2cbbe2', N'Admin', N'Admin', N'admin@gmail.com', N'aa', N'aa', N'aa')
INSERT [dbo].[User] ([Id], [AirlineId], [RoleId], [Name], [Surname], [Email], [Password], [Address], [PhoneNumber]) VALUES (N'6384f5ff-96a9-4e5d-b1f8-f0837d213985', NULL, N'dd1239f4-2645-456f-882a-7d2ab7d336b0', N'user', N'user', N'user@gmail.com', N'1', N'1', N'1')
ALTER TABLE [dbo].[AdditionalServiceAirline]  WITH CHECK ADD  CONSTRAINT [FK_AdditionalServiceAirline_Airline] FOREIGN KEY([AirlineId])
REFERENCES [dbo].[Airline] ([Id])
GO
ALTER TABLE [dbo].[AdditionalServiceAirline] CHECK CONSTRAINT [FK_AdditionalServiceAirline_Airline]
GO
ALTER TABLE [dbo].[AirlineDestination]  WITH CHECK ADD  CONSTRAINT [FK_AirlineDestination_Airline] FOREIGN KEY([AirlineId])
REFERENCES [dbo].[Airline] ([Id])
GO
ALTER TABLE [dbo].[AirlineDestination] CHECK CONSTRAINT [FK_AirlineDestination_Airline]
GO
ALTER TABLE [dbo].[AirlineDestination]  WITH CHECK ADD  CONSTRAINT [FK_AirlineDestination_Destination] FOREIGN KEY([DestinationId])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[AirlineDestination] CHECK CONSTRAINT [FK_AirlineDestination_Destination]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airline] FOREIGN KEY([AirlineId])
REFERENCES [dbo].[Airline] ([Id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airline]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airplane] FOREIGN KEY([AirplainId])
REFERENCES [dbo].[Airplane] ([Id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airplane]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Destination_From] FOREIGN KEY([DestinationIdFrom])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Destination_From]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Destination_To] FOREIGN KEY([DestinationIdTo])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Destination_To]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_TypeOfFlight] FOREIGN KEY([TypeId])
REFERENCES [dbo].[TypeOfFlight] ([Id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_TypeOfFlight]
GO
ALTER TABLE [dbo].[Friend]  WITH CHECK ADD  CONSTRAINT [FK_Friend_User_Recived] FOREIGN KEY([UserReceivedId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Friend] CHECK CONSTRAINT [FK_Friend_User_Recived]
GO
ALTER TABLE [dbo].[Friend]  WITH CHECK ADD  CONSTRAINT [FK_Friend_User_Send] FOREIGN KEY([UserSendId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Friend] CHECK CONSTRAINT [FK_Friend_User_Send]
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Destination] FOREIGN KEY([DestinationId])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[Hotel] CHECK CONSTRAINT [FK_Hotel_Destination]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Airline] FOREIGN KEY([AirlineId])
REFERENCES [dbo].[Airline] ([Id])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Airline]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Flight] FOREIGN KEY([FlightId])
REFERENCES [dbo].[Flight] ([Id])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Flight]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_User]
GO
ALTER TABLE [dbo].[RentaCar]  WITH CHECK ADD  CONSTRAINT [FK_RentaCar_Destination] FOREIGN KEY([DestinationId])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[RentaCar] CHECK CONSTRAINT [FK_RentaCar_Destination]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Flight] FOREIGN KEY([FlightId])
REFERENCES [dbo].[Flight] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Flight]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Seat1] FOREIGN KEY([SeatId])
REFERENCES [dbo].[Seat] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Seat1]
GO
ALTER TABLE [dbo].[Seat]  WITH CHECK ADD  CONSTRAINT [FK_Seat_Airplane] FOREIGN KEY([AirplaneId])
REFERENCES [dbo].[Airplane] ([Id])
GO
ALTER TABLE [dbo].[Seat] CHECK CONSTRAINT [FK_Seat_Airplane]
GO
ALTER TABLE [dbo].[Seat]  WITH CHECK ADD  CONSTRAINT [FK_Seat_TypeOfSeat] FOREIGN KEY([TypeId])
REFERENCES [dbo].[TypeOfSeat] ([Id])
GO
ALTER TABLE [dbo].[Seat] CHECK CONSTRAINT [FK_Seat_TypeOfSeat]
GO
ALTER TABLE [dbo].[SeatInfo]  WITH CHECK ADD  CONSTRAINT [FK_SeatInfo_Flight] FOREIGN KEY([FlightId])
REFERENCES [dbo].[Flight] ([Id])
GO
ALTER TABLE [dbo].[SeatInfo] CHECK CONSTRAINT [FK_SeatInfo_Flight]
GO
ALTER TABLE [dbo].[SeatInfo]  WITH CHECK ADD  CONSTRAINT [FK_SeatInfo_Seat] FOREIGN KEY([SeatId])
REFERENCES [dbo].[Seat] ([Id])
GO
ALTER TABLE [dbo].[SeatInfo] CHECK CONSTRAINT [FK_SeatInfo_Seat]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
