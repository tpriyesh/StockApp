USE [stock]
GO
/****** Object:  Table [dbo].[user]    Script Date: 05/09/2016 00:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[usercode] [varchar](500) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[activestatus] [bit] NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (1, N'arya', N'IrymTIeqei6/tfgZthXtb5pNIgmH4Ati3hxfBMG6YP8JI9PwgNt5lA==', N'88c1dac3fcf8f695d4f64b3e7740bae2', 1, N'sff@fsd.com')
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (2, N'awayi188', N'qkHxkW21LSP8yCgs1OxfOhzUlU63N1bNP8HdG8XGhx0JI9PwgNt5lA==', N'a08b8619e5a11ccdf719e1d9fcb186ce', 1, N'priyesh@wizni.com')
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (3, N'test', N'crnnWWmsz6Bn26CaWo4XY+w0DLiAthjJYD2t+0CHscoJI9PwgNt5lA==', N'7f8f537e271aa2afaabf80f2126d582c', 1, N'tpriyesh188@gmail.com')
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (4, N'test1', N'poEZsRW46JYik2gHpWhQX4vZp4xflGHCHo2aHP9comAJI9PwgNt5lA==', N'2861eb9b5bc4194880d18a6aed44f292', 1, N'tpriyessh188@gmail.com')
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (5, N'ali', N'5xMdSchM2F+++YRyipRR2A7KLyA0BNSN1GbhpiqnTaEJI9PwgNt5lA==', N'ebaee236efb84bbf5d8222eecbbc374f', 1, N'fsf@fdsf.com')
INSERT [dbo].[user] ([id], [username], [usercode], [password], [activestatus], [email]) VALUES (6, N'awayi1886', N'SUuQRncHGUMy0nksTvj2G16TjAl9rVTrzJPgwWmXuVUJI9PwgNt5lA==', N'799bf0153b7136cd65c3cd379de9a3f3', 1, N'gmchkr@gmail.com')
SET IDENTITY_INSERT [dbo].[user] OFF
/****** Object:  Table [dbo].[stock]    Script Date: 05/09/2016 00:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[stockcode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_stock] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[stock] ON
INSERT [dbo].[stock] ([id], [stockcode]) VALUES (1, N'msft')
INSERT [dbo].[stock] ([id], [stockcode]) VALUES (2, N'goog')
INSERT [dbo].[stock] ([id], [stockcode]) VALUES (3, N'appl')
SET IDENTITY_INSERT [dbo].[stock] OFF
/****** Object:  Table [dbo].[error]    Script Date: 05/09/2016 00:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[error](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[errordatetime] [datetime] NOT NULL,
	[errormessage] [text] NOT NULL,
	[errordescription] [text] NOT NULL,
 CONSTRAINT [PK_error] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[error] ON
INSERT [dbo].[error] ([id], [errordatetime], [errormessage], [errordescription]) VALUES (1, CAST(0x0000A60000DFA186 AS DateTime), N'Object reference not set to an instance of an object.', N'System.NullReferenceException: Object reference not set to an instance of an object.
   at System.Data.Linq.SqlClient.QueryConverter.VisitInvocation(InvocationExpression invoke)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitBinary(BinaryExpression b)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitWhere(Expression sequence, LambdaExpression predicate)
   at System.Data.Linq.SqlClient.QueryConverter.VisitSequenceOperatorCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitMethodCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.ConvertOuter(Expression node)
   at System.Data.Linq.SqlClient.SqlProvider.BuildQuery(Expression query, SqlNodeAnnotations annotations)
   at System.Data.Linq.SqlClient.SqlProvider.System.Data.Linq.Provider.IProvider.Execute(Expression query)
   at System.Data.Linq.DataQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at Stock.Repository.PersonalizedRepository.GetStocksOfUser(user userObj) in e:\Stock\Stock.Web\Stock.Repository\PersonalizedRepository.cs:line 34
   at Stock.Web.Controllers.PersonalizedStocksController.Index() in e:\Stock\Stock.Web\Stock.Web\Controllers\PersonalizedStocksController.cs:line 35
   at lambda_method(Closure , ControllerBase , Object[] )
   at System.Web.Mvc.ActionMethodDispatcher.Execute(ControllerBase controller, Object[] parameters)
   at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass42.<BeginInvokeSynchronousActionMethod>b__41()
   at System.Web.Mvc.Async.AsyncResultWrapper.<>c__DisplayClass8`1.<BeginSynchronous>b__7(IAsyncResult _)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<>c__DisplayClass39.<BeginInvokeActionMethodWithFilters>b__33()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass4f.<InvokeActionMethodFilterAsynchronously>b__49()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeActionMethodWithFilters>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<>c__DisplayClass2a.<BeginInvokeAction>b__20()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<BeginInvokeAction>b__22(IAsyncResult asyncResult)')
INSERT [dbo].[error] ([id], [errordatetime], [errormessage], [errordescription]) VALUES (2, CAST(0x0000A60000E0E414 AS DateTime), N'Object reference not set to an instance of an object.', N'System.NullReferenceException: Object reference not set to an instance of an object.
   at System.Data.Linq.SqlClient.QueryConverter.VisitInvocation(InvocationExpression invoke)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitBinary(BinaryExpression b)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitWhere(Expression sequence, LambdaExpression predicate)
   at System.Data.Linq.SqlClient.QueryConverter.VisitSequenceOperatorCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitMethodCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.ConvertOuter(Expression node)
   at System.Data.Linq.SqlClient.SqlProvider.BuildQuery(Expression query, SqlNodeAnnotations annotations)
   at System.Data.Linq.SqlClient.SqlProvider.System.Data.Linq.Provider.IProvider.Execute(Expression query)
   at System.Data.Linq.DataQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at Stock.Repository.PersonalizedRepository.GetStocksOfUser(user userObj) in e:\Stock\Stock.Web\Stock.Repository\PersonalizedRepository.cs:line 34
   at Stock.Web.Controllers.PersonalizedStocksController.GetUserStocks() in e:\Stock\Stock.Web\Stock.Web\Controllers\PersonalizedStocksController.cs:line 49
   at lambda_method(Closure , ControllerBase , Object[] )
   at System.Web.Mvc.ActionMethodDispatcher.Execute(ControllerBase controller, Object[] parameters)
   at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass42.<BeginInvokeSynchronousActionMethod>b__41()
   at System.Web.Mvc.Async.AsyncResultWrapper.<>c__DisplayClass8`1.<BeginSynchronous>b__7(IAsyncResult _)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<>c__DisplayClass39.<BeginInvokeActionMethodWithFilters>b__33()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass4f.<InvokeActionMethodFilterAsynchronously>b__49()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeActionMethodWithFilters>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<>c__DisplayClass2a.<BeginInvokeAction>b__20()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<BeginInvokeAction>b__22(IAsyncResult asyncResult)')
INSERT [dbo].[error] ([id], [errordatetime], [errormessage], [errordescription]) VALUES (3, CAST(0x0000A60000E18482 AS DateTime), N'Object reference not set to an instance of an object.', N'System.NullReferenceException: Object reference not set to an instance of an object.
   at System.Data.Linq.SqlClient.QueryConverter.VisitInvocation(InvocationExpression invoke)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitBinary(BinaryExpression b)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitWhere(Expression sequence, LambdaExpression predicate)
   at System.Data.Linq.SqlClient.QueryConverter.VisitSequenceOperatorCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitMethodCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.ConvertOuter(Expression node)
   at System.Data.Linq.SqlClient.SqlProvider.BuildQuery(Expression query, SqlNodeAnnotations annotations)
   at System.Data.Linq.SqlClient.SqlProvider.System.Data.Linq.Provider.IProvider.Execute(Expression query)
   at System.Data.Linq.DataQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at Stock.Repository.PersonalizedRepository.GetStocksOfUser(user userObj) in e:\Stock\Stock.Web\Stock.Repository\PersonalizedRepository.cs:line 34
   at Stock.Web.Controllers.PersonalizedStocksController.GetUserStocks() in e:\Stock\Stock.Web\Stock.Web\Controllers\PersonalizedStocksController.cs:line 49
   at lambda_method(Closure , ControllerBase , Object[] )
   at System.Web.Mvc.ActionMethodDispatcher.Execute(ControllerBase controller, Object[] parameters)
   at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass42.<BeginInvokeSynchronousActionMethod>b__41()
   at System.Web.Mvc.Async.AsyncResultWrapper.<>c__DisplayClass8`1.<BeginSynchronous>b__7(IAsyncResult _)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<>c__DisplayClass39.<BeginInvokeActionMethodWithFilters>b__33()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass4f.<InvokeActionMethodFilterAsynchronously>b__49()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeActionMethodWithFilters>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<>c__DisplayClass2a.<BeginInvokeAction>b__20()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<BeginInvokeAction>b__22(IAsyncResult asyncResult)')
INSERT [dbo].[error] ([id], [errordatetime], [errormessage], [errordescription]) VALUES (4, CAST(0x0000A60000E1DF91 AS DateTime), N'Object reference not set to an instance of an object.', N'System.NullReferenceException: Object reference not set to an instance of an object.
   at System.Data.Linq.SqlClient.QueryConverter.VisitInvocation(InvocationExpression invoke)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitBinary(BinaryExpression b)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.VisitExpression(Expression exp)
   at System.Data.Linq.SqlClient.QueryConverter.VisitWhere(Expression sequence, LambdaExpression predicate)
   at System.Data.Linq.SqlClient.QueryConverter.VisitSequenceOperatorCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitMethodCall(MethodCallExpression mc)
   at System.Data.Linq.SqlClient.QueryConverter.VisitInner(Expression node)
   at System.Data.Linq.SqlClient.QueryConverter.ConvertOuter(Expression node)
   at System.Data.Linq.SqlClient.SqlProvider.BuildQuery(Expression query, SqlNodeAnnotations annotations)
   at System.Data.Linq.SqlClient.SqlProvider.System.Data.Linq.Provider.IProvider.Execute(Expression query)
   at System.Data.Linq.DataQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at Stock.Repository.PersonalizedRepository.GetStocksOfUser(user userObj) in e:\Stock\Stock.Web\Stock.Repository\PersonalizedRepository.cs:line 34
   at Stock.Web.Controllers.PersonalizedStocksController.GetUserStocks() in e:\Stock\Stock.Web\Stock.Web\Controllers\PersonalizedStocksController.cs:line 49
   at lambda_method(Closure , ControllerBase , Object[] )
   at System.Web.Mvc.ActionMethodDispatcher.Execute(ControllerBase controller, Object[] parameters)
   at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass42.<BeginInvokeSynchronousActionMethod>b__41()
   at System.Web.Mvc.Async.AsyncResultWrapper.<>c__DisplayClass8`1.<BeginSynchronous>b__7(IAsyncResult _)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<>c__DisplayClass39.<BeginInvokeActionMethodWithFilters>b__33()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass4f.<InvokeActionMethodFilterAsynchronously>b__49()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeActionMethodWithFilters>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<>c__DisplayClass2a.<BeginInvokeAction>b__20()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass25.<BeginInvokeAction>b__22(IAsyncResult asyncResult)')
SET IDENTITY_INSERT [dbo].[error] OFF
/****** Object:  Table [dbo].[userstocks]    Script Date: 05/09/2016 00:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userstocks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[stockcode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_userstocks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[userstocks] ON
INSERT [dbo].[userstocks] ([id], [user_id], [stockcode]) VALUES (5, 2, N'appl')
INSERT [dbo].[userstocks] ([id], [user_id], [stockcode]) VALUES (7, 2, N'msft')
INSERT [dbo].[userstocks] ([id], [user_id], [stockcode]) VALUES (14, 4, N'goog')
INSERT [dbo].[userstocks] ([id], [user_id], [stockcode]) VALUES (15, 4, N'msft')
SET IDENTITY_INSERT [dbo].[userstocks] OFF
/****** Object:  ForeignKey [FK__userstock__user___060DEAE8]    Script Date: 05/09/2016 00:28:57 ******/
ALTER TABLE [dbo].[userstocks]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
