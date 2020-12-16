using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_Decorator
{
    class SystemSecurity : DecoratorOptions
    {
        public SystemSecurity(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Повышенной безопасности";
            Description = p.Description + ". " + this.Title + ". Передение и боковые" +
                "подушки безопасности, ESP - система динамической стабилизации автомобиля";

        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }

    class MediaNAV : DecoratorOptions
    {
        public MediaNAV(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Современный";
            Description = p.Description + ". " + this.Title + ". Обновленная мультимедийная" +
                " навигационная система";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15.99;
        }
    }

    class HeatSystem : DecoratorOptions
    {
        public HeatSystem(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". С подогревом.";
            Description = p.Description + ". " + this.Title + ". Современная система подгорева";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 10.99;
        }
    }

    class ParkingRadar : DecoratorOptions
    {
        public ParkingRadar(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Парктроник.";
            Description = p.Description + ". " + this.Title + ". Вспомогательная системы парковки";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 6.99;
        }
    }
}
