//专门计算工资的类族

interface ICalculateSalary{
   double CalcalateSalary(double baseSalary);
}

有很多子类实现了这接口：
public class CalcJuniorSalary: ICalculateSalary //计算新入职员工的薪水
public class CalcSeniorSalary: ICalculateSalary //计算新入职员工的薪水
public class CalcManagerSalary: ICalculateSalary //计算新入职员工的薪水


//接下来，在Employee,有个ICalculateSalary calcSalary成员变量


public class Employee:Person{
  int employeeId;
  double baseSalary;
  ICalculateSalary calcSalary;
  public void SetCalcSalary(ICalculateSalary calculateSalary){
    this.calcSalary=calculateSalary;
  }
 public double CalculateSalary(){
    return calcSalary.CalcalateSalary(this.baseSalary);
}