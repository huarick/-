Animal animal=new Tiger();
animal.Run();
animal=new Dog();
animal.Run();


一旦参数化隔离：（运行时，才会决定是什么 动物在跑）

void AnimalRun(Animal animal){

animal.Run(); //此处在你编写函数的时候是完全不知道会有什么 动物的，运行的时候在会气揭晓
}

即，在运行是，动态决定是哪个类