//Container���Ĳ��ݣ�ɢ�б�

Dictionary<string,object> container=Dictionary<string,object>();

//ֵ��������Ķ���
container.Add("configService",new ConfigService());
container.Add("DatabaseService",new DatabaseService());
container.Add("NewworkService",new NetworkService());

//Ϊ�˷������������key�ۺϵ�ĳ��class

class ServiceKey={

    public static readonly string ConfigService="ConfigService";
    public static readonly string DataBaseService="DatabaseService"";
}

//����

ConfigService configService=container[ServiceKeys.ConfigService];