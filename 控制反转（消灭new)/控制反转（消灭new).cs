//不要调我，我会去调你
//属性注入

//写通用性代码，如下：
void SetAnimal(Animal animal){
  this.animal=animal;
}

//客户调用注入：
Tiger tiger=new Tiger();
 obj.SetAnimal(tiger);