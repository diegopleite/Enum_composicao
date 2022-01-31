using System;
using System.Collections.Generic;
using System.Text;


namespace Exercicio_Enum_Composicao.Entities.Enums {
    enum OrderStatus : int {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
