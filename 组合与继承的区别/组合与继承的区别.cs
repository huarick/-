//��˼���˹���

public class Person{
private int age;
private string name;

public Int GetAge(){
return this.age;
}

public Int GetName(){
 return this.name;
}

//�ٶ���һ�����ˣ������ַ�ʽ��һ�ּ̳�

class SuperMan:Person{
	public void SuperPower();//��������
}

//�ڶ������

public classa  SuperMan{
 Person person;
 public int GetAge(){
	return person.GetAge();	
}

public int GetName(){
	return "SuperMan"+person.GetName();
}
public void SuperPower();
}

