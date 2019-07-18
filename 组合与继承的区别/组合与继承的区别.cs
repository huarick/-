//构思超人故事

public class Person{
private int age;
private string name;

public Int GetAge(){
return this.age;
}

public Int GetName(){
 return this.name;
}

//再定义一个超人，有两种方式，一种继承

class SuperMan:Person{
	public void SuperPower();//超人能力
}

//第二种组合

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

