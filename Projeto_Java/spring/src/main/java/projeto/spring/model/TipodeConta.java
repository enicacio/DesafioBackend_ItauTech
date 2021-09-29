package projeto.spring.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table (name="tb_tipoconta")
public class TipodeConta {

    @Id
    private int tipoConta;

    @Column (nullable = false)
    private String nomeTipoConta;

    public int getTipoConta() {
        return tipoConta;
    }

    public void setTipoConta(int tipoConta) {
        this.tipoConta = tipoConta;
    }

    public String getNomeTipoConta() {
        return nomeTipoConta;
    }

    public void setNomeTipoConta(String nomeTipoConta) {
        this.nomeTipoConta = nomeTipoConta;
    }
}
