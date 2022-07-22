using MyNoSqlServer.Abstractions;

namespace MyJetWallet.RemoteConfig;

public class MobileConfigNoSqlEntity: MyNoSqlDbEntity
{
    public const string TableName = "jetwallet-mobile-remote-config";
    public static string GeneratePartitionKey() => "config";
    public static string GenerateRowKey() => "config";
    
    public MobileRemoteConfig RemoteConfig { get; set; }
}