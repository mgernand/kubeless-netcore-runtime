using System;
using System.IO;
using Microsoft.AspNetCore.Http;

public class hellowithdata
{
    public object execute(HttpRequest request)
    {
        var input = new StreamReader(request.Body).ReadToEnd();
        return input;
    }
}