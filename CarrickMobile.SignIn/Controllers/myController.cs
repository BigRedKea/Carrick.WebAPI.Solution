imports Carrick.BusinessLogic
imports Carrick.BusinessLogic.Interfaces
imports Carrick.ClientData.DataProviders

imports System



    public class DotNetController : inherits BusinessLogic

    Private  mc as  ModelDataProvider 

        public sub new (baseurl as string , username As string , password As string )
            MyBase.New()
            mc = new ModelDataProvider(New SQLite.Net.Platform.Generic.SQLitePlatformGeneric(),baseurl, username, password)
            mybase.DataProviders = mc

        End sub

        public sub Execute()
            mc.CreateModel()
            mc.LoadLocalData()

            mc.Sync()

        End sub
    End class
