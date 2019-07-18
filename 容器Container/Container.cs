//Container核心部份，散列表

Dictionary<string,object> container=Dictionary<string,object>();

//值，就是类的对象
container.Add("configService",new ConfigService());
container.Add("DatabaseService",new DatabaseService());
container.Add("NewworkService",new NetworkService());

//为了方便管理，把所有key综合到某个class

class ServiceKey={

    public static readonly string ConfigService="ConfigService";
    public static readonly string DataBaseService="DatabaseService"";
}

//调用

ConfigService configService=container[ServiceKeys.ConfigService];