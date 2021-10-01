package projeto.spring.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

@Entity
@Table (name="tb_contas")
public class Conta {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long numConta;

    @Column(nullable = false)
    private int agencia;

    @OneToOne
    @JoinColumn(name="tipo_conta")
    private TipodeConta tipoConta;

    @Column(nullable = false)
    private double saldo;
   
    @ManyToOne
    @JoinColumn(name = "titular")
    @JsonIgnoreProperties("contas")
    private TitularConta titular;

    public long getNumConta() {
        return numConta;
    }

    public void setNumConta(long numConta) {
        this.numConta = numConta;
    }

    public int getAgencia() {
        return agencia;
    }

    public void setAgencia(int agencia) {
        this.agencia = agencia;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public TitularConta getTitular() {
        return titular;
    }

    public void setTitular(TitularConta titular) {
        this.titular = titular;
    }

    public TipodeConta getTipoConta() {
        return tipoConta;
    }

    public void setTipoConta(TipodeConta tipoConta) {
        this.tipoConta = tipoConta;
    }   

    

}
