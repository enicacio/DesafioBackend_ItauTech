package projeto.spring.repository;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import projeto.spring.model.TipodeConta;

public interface TipodeRepo extends CrudRepository<TipodeConta, Integer> {
    // public Object findbByTipo(Integer tipoConta);
    @Query(value = "select * from tb_contas where tipo_conta = ?", nativeQuery = true)
    public Object buscaContaTipo(int tipo_conta);
}
