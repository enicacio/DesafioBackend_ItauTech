package projeto.spring.repository;

import org.springframework.data.repository.CrudRepository;
import projeto.spring.model.TipodeConta;

public interface TipodeRepo extends CrudRepository<TipodeConta, Integer> {
    
}
