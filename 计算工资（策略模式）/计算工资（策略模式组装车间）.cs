//ר�ż��㹤�ʵ�����

interface ICalculateSalary{
   double CalcalateSalary(double baseSalary);
}

�кܶ�����ʵ������ӿڣ�
public class CalcJuniorSalary: ICalculateSalary //��������ְԱ����нˮ
public class CalcSeniorSalary: ICalculateSalary //��������ְԱ����нˮ
public class CalcManagerSalary: ICalculateSalary //��������ְԱ����нˮ


//����������Employee,�и�ICalculateSalary calcSalary��Ա����


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