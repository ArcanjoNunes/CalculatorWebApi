namespace CalculatorWebApi.Controllers;

[ApiController]
[Route("api")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorRepository _calculator;

    public CalculatorController(ICalculatorRepository calculator)
    {
        _calculator = calculator;
    }

    [HttpGet]
    [Route("/")]
    public string Info()
    {
        return "Calculator Server...";
    }

    [HttpPost]
    [Route("Add")]
    public double Add([FromBody] CalculatorParameter calcParam)
    {
        return _calculator.Add(calcParam);
    }

    [HttpPost]
    [Route("Subtract")]
    public double Subtract([FromBody] CalculatorParameter calcParam)
    {
        return _calculator.Subtract(calcParam);
    }

    [HttpPost]
    [Route("Multiply")]
    public double Multiply([FromBody] CalculatorParameter calcParam)
    {
        return _calculator.Multiply(calcParam);
    }

    [HttpPost]
    [Route("DivideBy")]
    public double DivideBy([FromBody] CalculatorParameter calcParam)
    {
        return _calculator.DivideBy(calcParam);
    }
}
