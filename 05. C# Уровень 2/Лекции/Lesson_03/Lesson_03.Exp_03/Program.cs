// Наследование обобщенных типов

namespace Lesson_03.Exp_03
{
    class Program
    {
        static void Main()
        {
            // Наследование первого типа (generic базовый класс, non-generic наследник)
            CatType animalsT1_01 = new CatType(Sex.Male);
            AnimalsType<Sex> animalsT1_02 = new CatType(Sex.Male);
            AnimalsType<Sex> animalsT1_03 = new AnimalsType<Sex>(Sex.Male);

            // Наследование первого типа (generic базовый класс, generic наследник того же типа)
            AnimalsType<string> animalsT2_01 = new AnimalsType<string>("Male");
            AnimalsType<bool> animalsT2_02 = new AnimalsType<bool>(true);

            // Наследование первого типа (generic базовый класс, generic наследник иного типа)
            CatType01<int> animalsT3_01 = new CatType01<int>(Sex.Male);
            AnimalsType<Sex> animalsT3_02 = new CatType01<int>(Sex.Male);
            AnimalsType<Sex> animalsT3_03 = new AnimalsType<Sex>(Sex.Male);

            // Наследование первого типа (generic базовый класс, generic наследник сочетание параметра базового класса и своих типов)
            CatType02<int, Sex, object> animalsT4_01 = new CatType02<int, Sex, object>(Sex.Male);
            AnimalsType<Sex> animalsT4_02 = new CatType02<long, Sex, long>(Sex.Male);
            AnimalsType<Sex> animalsT4_03 = new AnimalsType<Sex>(Sex.Male);
        }
    }

    public enum Sex
    {
        Male,
        Female,
        Undefined
    }

    public class AnimalsType<T>
    {
        public T Gender = default;

        public AnimalsType(T gender) => Gender = gender;
    }
    public class CatType : AnimalsType<Sex>
    {
        // Обязательно при наследовании указываем тип базового класса
        public CatType(Sex gender) : base(gender) => Gender = gender;
    }
    public class CatType<T> : AnimalsType<T>
    {
        public CatType(T gender) : base(gender) => Gender = gender;
    }
    public class CatType01<T> : AnimalsType<Sex>
    {
        // Обязательно при наследовании указываем тип базового класса
        public CatType01(Sex gender) : base(gender) => Gender = gender;
    }
    public class CatType02<R,T,U> : AnimalsType<T>
    {
        public CatType02(T gender) : base(gender) => Gender = gender;
    }



}