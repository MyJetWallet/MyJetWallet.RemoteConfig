using MyNoSqlServer.Abstractions;

namespace MyJetWallet.RemoteConfig;

public class EmbeddedConfigNoSqlEntity: MyNoSqlDbEntity
{
    public const string TableName = "embedded-remote-config";
    public static string GeneratePartitionKey() => "config";
    public static string GenerateRowKey() => "embedded";
    
    public MobileRemoteConfig RemoteConfig { get; set; }
}