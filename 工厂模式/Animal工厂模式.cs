void show(){
  Animal animal;
  if(name=="tiger")
       animal=new tiger();
  else if (name="lion")
       animal=new Lion();
ShowAnimal(animal)
}

 此时可以改造 为：

Animal ProvideAnimal(string name){
   Animal animal;
     if(name=="tiger")
       animal=new tiger();
  else if (name="lion")
       animal=new Lion();
}

void Show(string name){
  Animal animal=ProvideAnimal(name);
  ShowAnimal(animal);
}