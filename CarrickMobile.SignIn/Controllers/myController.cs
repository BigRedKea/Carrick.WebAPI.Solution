﻿imports Scout.BusinessLogic.BusinessLogic
imports Scout.BusinessLogic.Interfaces
imports ScoutDataModelPortable.DataProviders
imports ScoutDataModelPortable.Model
imports System



    public class DotNetController : inherits BusinessLogic

    Private  mc as  ModelDataProvider 

        public sub new (baseurl as string , username As string , password As string )
            MyBase.New()
            mc = new ModelDataProvider(baseurl, username, password)
            mybase.DataProviders = mc

        End sub

        public sub Execute()
            mc.CreateModel(new SQLite.Net.Platform.Generic.SQLitePlatformGeneric())
            mc.LoadLocalData()

            mc.Sync()

        End sub
    End class