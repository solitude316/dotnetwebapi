# dotnetwebapi

以 Side Project 的方式來記錄學習 .NET core 6 的進度。

## 更新紀錄
### 202-07-11 串接 Postgresql 完成。

#### 步驟
    1. 安裝 Nuget package
    ```bash
        dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
        dotnet add Microsoft.EntityFrameworkCore.Design
    ```
2. 定義 DataContext 檔案 Api.Data.PgSQLContext.cs
3. 建立 EF migration，指令：```dotnet ef migrations add InitialCreate ```
4. 執行 migration，指令：```dotnet ef database update```


#### 注意事項
PostgreSQL 14.4 預設使用 SSL 連線，若沒有準備 SSL 憑證，需要在 ConnectionString 上設定關掉。
```json
{
    "ConnectionStrings": {
        "DefaultConneciton" : "Server=localhost;Port=5432;User Id=postgres; password=password1234; database=dashboard; SSL Mode=Disable"
    }
}
```


## 參考資料 
1. PostgreSQL 官方文件 [Npgsql Entity Framework Core Provider](https://www.npgsql.org/efcore/)
2. 參考 [.NET 6.0 - Connect to PostgreSQL Database with Entity Framework Core](https://jasonwatmore.com/post/2022/06/23/net-6-connect-to-postgresql-database-with-entity-framework-core) 一文，建立 Database 連線