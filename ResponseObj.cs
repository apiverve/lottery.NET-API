using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("cashValue")]
    public string cashValue { get; set; }

    [JsonProperty("doublePlay")]
    public string[] doublePlay { get; set; }

    [JsonProperty("drawDate")]
    public string drawDate { get; set; }

    [JsonProperty("jackpot")]
    public string jackpot { get; set; }

    [JsonProperty("latestNumbersDate")]
    public string latestNumbersDate { get; set; }

    [JsonProperty("numbers")]
    public string[] numbers { get; set; }

    [JsonProperty("lotteryType")]
    public string lotteryType { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
