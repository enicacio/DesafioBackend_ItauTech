package projeto.spring.repository;

import org.springframework.data.repository.CrudRepository;
import projeto.spring.model.TitularConta;

public interface TitularRepo extends CrudRepository<TitularConta, Long> {
}
