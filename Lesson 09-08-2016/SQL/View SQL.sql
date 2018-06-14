USE [AdventureWorks2014]
GO

/****** Object:  View [dbo].[ComplexPersonView]    Script Date: 9/9/2016 8:41:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ComplexPersonView]
AS
SELECT        Person.Person.Title, Person.Person.FirstName, Person.Person.LastName, Person.Person.AdditionalContactInfo, Person.Person.Demographics, Person.PersonPhone.PhoneNumber, 
                         Person.PersonPhone.PhoneNumberTypeID, Person.Person.BusinessEntityID, Person.Address.AddressLine1, Person.Address.AddressLine2, Person.Address.City, Person.StateProvince.Name, 
                         Person.StateProvince.StateProvinceCode, Person.Address.PostalCode
FROM            Person.Person INNER JOIN
                         Person.PersonPhone ON Person.Person.BusinessEntityID = Person.PersonPhone.BusinessEntityID INNER JOIN
                         Person.BusinessEntityAddress ON Person.Person.BusinessEntityID = Person.BusinessEntityAddress.BusinessEntityID INNER JOIN
                         Person.Address ON Person.BusinessEntityAddress.AddressID = Person.Address.AddressID INNER JOIN
                         Person.StateProvince ON Person.Address.StateProvinceID = Person.StateProvince.StateProvinceID

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Person (Person)"
            Begin Extent = 
               Top = 29
               Left = 31
               Bottom = 280
               Right = 323
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonPhone (Person)"
            Begin Extent = 
               Top = 0
               Left = 686
               Bottom = 130
               Right = 890
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BusinessEntityAddress (Person)"
            Begin Extent = 
               Top = 158
               Left = 592
               Bottom = 307
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Address (Person)"
            Begin Extent = 
               Top = 147
               Left = 985
               Bottom = 277
               Right = 1157
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StateProvince (Person)"
            Begin Extent = 
               Top = 6
               Left = 361
               Bottom = 247
               Right = 577
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 14640
         Width = 1500
         Width = 1500
         Width = 2835
         Width = 1500
         Width = 1500
         Widt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ComplexPersonView'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'h = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ComplexPersonView'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ComplexPersonView'
GO


