using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
 public class Transaction : BaseVM
{
public int Id { get; set; }
/*
public IEnumerable<Transaction> SimilarTransactions {
get {
return from t in VM.Transactions
where t.Payee == this.Payee
select t;
}
}
*/
private DateTime _Date;
public DateTime Date
{
get { return _Date; }
set { _Date = value; OnPropertyChanged(); }
}
private string _Payee;
public string Payee
{
get { return _Payee; }
set { _Payee = value; OnPropertyChanged(); }
}
public int AccountId { get; set; }
private Account _Account;
public virtual Account Account
{
get { return _Account; }
set { _Account = value; OnPropertyChanged(); }
}
private double _Amount;
public double Amount
{
get { return _Amount; }
set { _Amount = value; OnPropertyChanged(); OnPropertyChanged("Currency2"); }
}
public double Currency2
{
get
{
if (ExchangeRateSing.Instance.Rates == null) return 0;
return Amount * ExchangeRateSing.Instance.Rates.CAD;
}
}
private string _Tag;
public string Tag
{
get { return _Tag; }
set { _Tag = value; OnPropertyChanged(); }
}
}
public class Account
{
public int Id { get; set; }
public string Name { get; set; }
public string Institution { get; set; }
public bool Business { get; set; }
public virtual IList<Transaction> Transactions { get; set; }
}
public class ExchangeRateSing
{
private ExchangeRateSing() { }
private static ExchangeRateSing _Instance;
public static ExchangeRateSing Instance
{
get { if (_Instance == null)_Instance = new ExchangeRateSing(); return _Instance; }
}
private Rates _Rates;
public Rates Rates
{
get { return _Rates; }
set { _Rates = value; }
}
}
public class ExchageRate
{
public string disclaimer { get; set; }
public string license { get; set; }
public int timestamp { get; set; }
public string _base { get; set; }
public Rates rates { get; set; }
}
public class Rates
{
    public float AED { get; set; }
    public float AFN { get; set; }
    public float ALL { get; set; }
    public float AMD { get; set; }
    public float ANG { get; set; }
    public float AOA { get; set; }
    public float ARS { get; set; }
    public float AUD { get; set; }
    public float AWG { get; set; }
    public float AZN { get; set; }
    public float BAM { get; set; }
    public float BBD { get; set; }
    public float BDT { get; set; }
    public float BGN { get; set; }
    public float BHD { get; set; }
    public float BIF { get; set; }
    public float BMD { get; set; }
    public float BND { get; set; }
    public float BOB { get; set; }
    public float BRL { get; set; }
    public float BSD { get; set; }
    public float BTC { get; set; }
    public float BTN { get; set; }
    public float BWP { get; set; }
    public float BYR { get; set; }
    public float BZD { get; set; }
    public float CAD { get; set; }
    public float CDF { get; set; }
    public float CHF { get; set; }
    public float CLF { get; set; }
    public float CLP { get; set; }
    public float CNY { get; set; }
    public float COP { get; set; }
    public float CRC { get; set; }
    public float CUC { get; set; }
    public float CUP { get; set; }
    public float CVE { get; set; }
    public float CZK { get; set; }
    public float DJF { get; set; }
    public float DKK { get; set; }
    public float DOP { get; set; }
    public float DZD { get; set; }
    public float EEK { get; set; }
    public float EGP { get; set; }
    public float ERN { get; set; }
    public float ETB { get; set; }
    public float EUR { get; set; }
    public float FJD { get; set; }
    public float FKP { get; set; }
    public float GBP { get; set; }
    public float GEL { get; set; }
    public float GGP { get; set; }
    public float GHS { get; set; }
    public float GIP { get; set; }
    public float GMD { get; set; }
    public float GNF { get; set; }
    public float GTQ { get; set; }
    public float GYD { get; set; }
    public float HKD { get; set; }
    public float HNL { get; set; }
    public float HRK { get; set; }
    public float HTG { get; set; }
    public float HUF { get; set; }
    public float IDR { get; set; }
    public float ILS { get; set; }
    public float IMP { get; set; }
    public float INR { get; set; }
    public float IQD { get; set; }
    public float IRR { get; set; }
    public float ISK { get; set; }
    public float JEP { get; set; }
    public float JMD { get; set; }
    public float JOD { get; set; }
    public float JPY { get; set; }
    public float KES { get; set; }
    public float KGS { get; set; }
    public float KHR { get; set; }
    public float KMF { get; set; }
    public float KPW { get; set; }
    public float KRW { get; set; }
    public float KWD { get; set; }
    public float KYD { get; set; }
    public float KZT { get; set; }
    public float LAK { get; set; }
    public float LBP { get; set; }
    public float LKR { get; set; }
    public float LRD { get; set; }
    public float LSL { get; set; }
    public float LTL { get; set; }
    public float LVL { get; set; }
    public float LYD { get; set; }
    public float MAD { get; set; }
    public float MDL { get; set; }
    public float MGA { get; set; }
    public float MKD { get; set; }
    public float MMK { get; set; }
    public float MNT { get; set; }
    public float MOP { get; set; }
    public float MRO { get; set; }
    public float MTL { get; set; }
    public float MUR { get; set; }
    public float MVR { get; set; }
    public float MWK { get; set; }
    public float MXN { get; set; }
    public float MYR { get; set; }
    public float MZN { get; set; }
    public float NAD { get; set; }
    public float NGN { get; set; }
    public float NIO { get; set; }
    public float NOK { get; set; }
    public float NPR { get; set; }
    public float NZD { get; set; }
    public float OMR { get; set; }
    public float PAB { get; set; }
    public float PEN { get; set; }
    public float PGK { get; set; }
    public float PHP { get; set; }
    public float PKR { get; set; }
    public float PLN { get; set; }
    public float PYG { get; set; }
    public float QAR { get; set; }
    public float RON { get; set; }
    public float RSD { get; set; }
    public float RUB { get; set; }
    public float RWF { get; set; }
    public float SAR { get; set; }
    public float SBD { get; set; }
    public float SCR { get; set; }
    public float SDG { get; set; }
    public float SEK { get; set; }
    public float SGD { get; set; }
    public float SHP { get; set; }
    public float SLL { get; set; }
    public float SOS { get; set; }
    public float SRD { get; set; }
    public float STD { get; set; }
}
}

