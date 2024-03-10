//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}


void Calculate()
{

    bool isCorrectCode = true;

    try
    {

        //int a = 5;
        //int b = 0;
        //var result = a / b;
        //Console.WriteLine(result);

        //if (b == 0) 
        //{
        //    return;
        //}

        int[] arr = { 1, 2, 3 };

        //arr[5] = 100;
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);

    }
    finally
    {
        SendMessage(isCorrectCode);
    }


}
//Calculate();



Rashad rashad = new Rashad(6);
Rashad rashad2 = new Rashad();





void SendMessage(bool isCorrectCode)
{
    if (isCorrectCode)
    {
        Console.WriteLine("Your message sent successfully");
    }
    else
    {
        Console.WriteLine("Your message failed");
    }

}

string GetById(int? id)
{
    try
    {

        if (id == null)
        {
            //throw new ArgumentNullException(nameof(id),"Salam menem Exception");
            throw new CustomArgumentNullException("Argument cannot be null");
        }
        //ArgumentNullException.ThrowIfNull(id);
        return "Kamran bey";
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}
var result = GetById(null);
Console.WriteLine(result);