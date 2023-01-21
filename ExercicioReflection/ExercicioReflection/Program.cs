using System.Reflection;

namespace ExercicioReflection {
    internal class Program {
        static void Main(string[] args) {

            Student student = new Student();
            //chamando o metodo
            DisplayPublicProperties(student);

            //exibindo as propriedades publicas da classe student
            static void DisplayPublicProperties(object studentInstance) {
                var properties = studentInstance.GetType().GetProperties();
                foreach (var property in properties) {
                    if (property.Name == "Name" || property.Name == "University" || property.Name == "RollNumber") {
                        Console.WriteLine(property.Name + ": " + property.GetValue(studentInstance));
                    }
                }
            }
            

            static void CreateInstance() {

                //instanciando o objeto da class student
                Type studentType = typeof(Student);
                object studentInstance = Activator.CreateInstance(studentType);

                //preenchendo as propriedades publicas do objeto
                PropertyInfo nameProperty = studentType.GetProperty("Name");
                nameProperty.SetValue(studentInstance, "Junior");

                PropertyInfo universityProperty = studentType.GetProperty("University");
                universityProperty.SetValue(studentInstance, "Senac");

                PropertyInfo rollNumberProperty = studentType.GetProperty("RollNumber");
                rollNumberProperty.SetValue(studentInstance, "1234");

                //chamando o metodo DisplayInfo(sem argumentos)

                MethodInfo displayInfoMethod = studentType.GetMethod("DisplayInfo");
                displayInfoMethod.Invoke(studentInstance, null);

            }



        }
    }
}