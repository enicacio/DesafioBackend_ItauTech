package projeto.spring.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

@Entity
@Table (name="tb_contas")
public class Conta {
    
    @Id
    @Column (nullable = true, unique = true)
    private long numConta;

    @Column(nullable = false)
    private int agencia;

    @Column(nullable = false)
    private int tipoConta; // 0 - conta corrente, 1 - poupança, 2 - investimento

    @Column(nullable = false)
    private double saldo;
   
    @ManyToOne
    @JoinColumn(name = "titular")
    // @JsonIgnoreProperties("contas")
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

    public int getTipoConta() {
        return tipoConta;
    }

    public void setTipoConta(int tipoConta) {
        this.tipoConta = tipoConta;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
}
