// See https://aka.ms/new-console-template for more information

using MyJetWallet.RemoteConfig;
using MyNoSqlServer.Abstractions;
using MyNoSqlServer.DataWriter;

var writer =new MyNoSqlServerDataWriter<MobileConfigNoSqlEntity>(() => "http://192.168.70.80:5123", MobileConfigNoSqlEntity.TableName,
    true, DataSynchronizationPeriod.Sec5);

await writer.CreateTableIfNotExistsAsync();

var config = new MobileRemoteConfig() {Config = new Dictionary<string, string>()};

var entity = new MobileConfigNoSqlEntity()
{
  PartitionKey = MobileConfigNoSqlEntity.GeneratePartitionKey(),
  RowKey = MobileConfigNoSqlEntity.GenerateRowKey(),
  RemoteConfig = config
};

await writer.InsertOrReplaceAsync(entity);

Console.WriteLine("Success");

