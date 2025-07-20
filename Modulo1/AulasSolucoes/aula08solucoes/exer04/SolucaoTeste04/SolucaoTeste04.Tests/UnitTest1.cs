using System;
using System.Collections.Generic;
using SolucaoTeste04.Classes;
namespace SolucaoTeste04.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void procurando_placa_cadastrada()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(carro);
        Assert.IsTrue(veiculosCadastrados.ConsultarPlaca("jaz2a99") != null);
    }

    [Test]
    public void procurando_placa_cadastrada_errorNull()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(carro);
        Assert.IsTrue(veiculosCadastrados.ConsultarPlaca("jaz2a90") != null);
    }

    [Test]
    public void consultando_placa_error_placa_nao_cadastrada()
    {
        Moto moto = new Moto("MDZ6876", 2024, "motocicleta", 5);
        moto.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        Assert.IsTrue(veiculosCadastrados.ConsultarPlaca("MDZ6876") != null);
    }

    [Test]
    public void cadastrando_placa()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Moto moto = new Moto("MDZ6875", 2019, "motocicleta", 5);
        moto.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(carro);
        Assert.IsTrue(veiculosCadastrados.Cadastrar(moto) == true);
    }

    [Test]
    public void cadastrando_placa_error_placa_ja_cadastrada()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(carro);
        Assert.IsTrue(veiculosCadastrados.Cadastrar(carro) == true);
    }

    [Test]
    public void cadastrando_veiculo_error_fabricado_em_2024()
    {
        Moto moto = new Moto("MDZ6876", 2024, "motocicleta", 5);
        moto.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        Assert.IsTrue(veiculosCadastrados.Cadastrar(moto) != false);
    }

    [Test]
    public void carro_qt_passageiros_certa()
    {
        Carro carro= new Carro("j1g4chad", 2020, "optimus prime", 2);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.QtPassageiros == 2);
    }

    [Test]
    public void carro_qt_passageiros_error4()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.QtPassageiros == 4);
    }

    [Test]
    public void consultando_tipo_do_carro()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.MostrarTipo() == 1);
    }

    [Test]
    public void consultando_tipo_do_carro_error100()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.MostrarTipo() == 100);
    }

    [Test]
    public void consultando_tipo_da_moto()
    {
        Moto moto= new Moto("sidney123", 2020, "motobike", 20);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.MostrarTipo() == 2);
    }

    [Test]
    public void consultando_tipo_da_moto_error15()
    {
        Moto moto= new Moto("sidney123", 2020, "motobike", 20);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.MostrarTipo() == 15);
    }
    
    [Test]
    public void moto_qt_cilindradas()
    {
        Moto moto= new Moto("sidney123", 2020, "motobike", 20);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.QtCilindradas == 20);
    }

    [Test]
    public void moto_qt_cilindradas_error7()
    {
        Moto moto= new Moto("kakaboom", 2017, "randandan", 10);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.QtCilindradas == 7);
    }

    [Test]
    public void consultando_tipo_do_caminhao()
    {
        Caminhao caminhao= new Caminhao("gtaV", 2010, "truck", 20000.00, 5000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.MostrarTipo() == 3);
    }

    [Test]
    public void consultando_tipo_do_caminhao_error7()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.MostrarTipo() == 7);
    }

    [Test]
    public void caminhao_peso_total()
    {
        Caminhao caminhao= new Caminhao("gtaV", 2010, "truck", 20000.00, 5000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.PesoTotal == 20000.00);
    }

    [Test]
    public void caminhao_peso_total_error5000()
    {
        Caminhao caminhao= new Caminhao("gtaV", 2010, "truck", 20000.00, 5000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.PesoTotal == 5000);
    }

    [Test]
    public void caminhao_valor_carga()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.ValorCarga == 12000.00);
    }

    [Test]
    public void caminhao_valor_carga_error20000()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.ValorCarga == 20000);
    }

    [Test]
    public void valor_pedagio_carro()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.Pedagio() == 20.00);
    }

    [Test]
    public void valor_pedagio_carro_error50()
    {
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        Assert.IsTrue(carro.Pedagio() == 50.00);
    }

    [Test]
    public void valor_pedagio_moto()
    {
        Moto moto= new Moto("kakaboom", 2017, "randandan", 10);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.Pedagio() == 10.00);
    }

    [Test]
    public void valor_pedagio_moto_error35()
    {
        Moto moto= new Moto("kakaboom", 2017, "randandan", 10);
        moto.TipoVeiculo();
        Assert.IsTrue(moto.Pedagio() == 35.00);
    }

    [Test]
    public void valor_pedagio_caminhao()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.Pedagio() == 40.00);
    }

    [Test]
    public void valor_pedagio_caminhao_error100()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        Assert.IsTrue(caminhao.Pedagio() == 100.00);
    }

    [Test]
    public void excluindo_veiculo()
    {
        Moto moto = new Moto("1234aa", 2024, "motocicleta", 5);
        moto.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(moto);
        Assert.IsTrue(!(veiculosCadastrados.ExcluirVeiculo("1234aa") == true));
    }

    [Test]
    public void excluindo_veiculo_error_placa_errada()
    {
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        veiculosCadastrados.Cadastrar(caminhao);
        Assert.IsTrue(veiculosCadastrados.ExcluirVeiculo("hollowkngh") == true);
    }

    [Test]
    public void excluindo_veiculo_error_placa_nao_cadastrada()
    {
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        Assert.IsTrue(veiculosCadastrados.ExcluirVeiculo("jay8b34") == true);
    }

    [Test]
    public void listando_veiculos_cadastrados()
    {
        CrudVeiculo veiculosCadastrados = new CrudVeiculo(null,  0, null);
        Caminhao caminhao= new Caminhao("hollowknight", 2022, "carga", 15750.50, 12000.00);
        caminhao.TipoVeiculo();
        veiculosCadastrados.Cadastrar(caminhao);
        Moto moto = new Moto("1234aa", 2024, "motocicleta", 5);
        moto.TipoVeiculo();
        veiculosCadastrados.Cadastrar(moto);
        Carro carro= new Carro("jaz2a99", 2020, "4 rodas", 3);
        carro.TipoVeiculo();
        veiculosCadastrados.Cadastrar(carro);
        Assert.IsTrue(veiculosCadastrados.ExibirVeiculos() is Dictionary<String, Veiculo>);
    }
}