using System.Collections.Generic;
using System;

public class Pedido
{
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
    public string Estado { get; set; }
    public string TipoPedido { get; set; }  // 'Mesa' o 'Domicilio'
    public string Direccion { get; set; }
    public int IdMesa { get; set; }
    public List<DetallePedido> Detalles { get; set; }
}

public class DetallePedido
{
    public int IdDetalle { get; set; }
    public int IdPedido { get; set; }
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
}
