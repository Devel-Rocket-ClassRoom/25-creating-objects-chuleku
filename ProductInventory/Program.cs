using System;
Console.WriteLine("=== 상품 목록 ===");
Product notebook = new Product
{
    Name = "노트북",
    Price = 1500000,
    Stock = 5
};
Product mouse = new Product
{
    Name = "마우스",
    Price = 35000,
    Stock = 20
};
Product keyboard = new Product
{
    Name = "키보드",
    Price = 89000,
    Stock = 15
};
Console.WriteLine(notebook);
Console.WriteLine(mouse);
Console.WriteLine(keyboard);
Console.WriteLine();
Console.WriteLine("=== 거래 ===");
notebook.Sell(2);
mouse.Sell(5);
keyboard.Sell(20);
keyboard.AddStock(10);
Console.WriteLine();
Console.WriteLine("=== 최종 상품 목록 ===");
Console.WriteLine(notebook);
Console.WriteLine(mouse);
Console.WriteLine(keyboard);
Console.WriteLine();
Console.WriteLine("=== 총 재고 가치 ===");
notebook.GetTotalValue();
mouse.GetTotalValue();
keyboard.GetTotalValue();
Console.WriteLine("---");
Console.WriteLine($"전체 재고 총 가치: {notebook.Totalprice+mouse.Totalprice+keyboard.Totalprice}원");
class Product
{
    public string Name;
    public int Price;
    public int Stock;
    public int Totalprice;
    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"[{Name}] {quantity}개 재고 추가. 현재 재고: {Stock}개 ");
    }
    public void Sell(int quantity)
    {
        if (Stock < quantity)
        {
            Console.WriteLine($"[{Name}] {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock}개)");
        }
        else
        {
            Stock-=quantity;
            Console.WriteLine($"{Name} {quantity}개 판매 완료. 남은 재고: {Stock}");
        }
    }
    public void GetTotalValue()
    {
        Totalprice = Price * Stock;
        Console.WriteLine($"{Name}: {Totalprice}원");
    }
    public override string ToString()
    {
        return $"[{Name}] 가격: {Price} (재고: {Stock}개)";
    }
}