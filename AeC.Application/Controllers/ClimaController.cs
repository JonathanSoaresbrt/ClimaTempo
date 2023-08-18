using AeC.Application.Services.Interfaces;
using AeC.Domain.Dto;
using AeC.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AeC.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class ClimaController : ControllerBase
{
    private readonly IApplicationServiceAeroporto _applicationServiceAeroporto;
    private readonly IApplicationServiceCidade _applicationServiceCidade;

    public ClimaController(IApplicationServiceAeroporto applicationServiceAeroporto, IApplicationServiceCidade applicationServiceCidade)
    {
        _applicationServiceAeroporto = applicationServiceAeroporto;
        _applicationServiceCidade = applicationServiceCidade;
    }

    [HttpPost("aeroporto/{icaoCodigo}")]
    public async Task<ActionResult<AeroportoClima>> GetClimaAeroporto(string icaoCodigo)
    {
        var result = await _applicationServiceAeroporto.GravarClima(icaoCodigo);

        return Ok(result);
    }

    [HttpPost("cidade/{codigoCidade}")]
    public async Task<ActionResult<CidadeClima>> GetClimaAeroporto(int codigoCidade)
    {
        var result = await _applicationServiceCidade.GravarCidade(codigoCidade);

        return Ok(result);
    }
}
