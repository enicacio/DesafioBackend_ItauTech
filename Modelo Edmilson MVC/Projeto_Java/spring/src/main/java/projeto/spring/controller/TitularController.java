package projeto.spring.controller;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import projeto.spring.model.TitularConta;
import projeto.spring.repository.TitularRepo;

@RestController
@RequestMapping("/clientes")
@CrossOrigin("*")
public class TitularController {

    @Autowired
    private TitularRepo repo;

    //************ Teste dos clientes *************/
    @GetMapping() // Buscar todos os clientes
    public List<TitularConta> obterTodos() {
        return (List<TitularConta>) repo.findAll(); 
    }

    // *********** Cadastro dos novos clientes ************
    @PostMapping("/novo") // Adicionar novos
    public ResponseEntity<TitularConta> novoCliente(@RequestBody TitularConta cliente) { 
        if (cliente.getCodInt() != 0) {
            return ResponseEntity.status(400).build(); 
        }
        TitularConta novoCliente = repo.save(cliente);
        return ResponseEntity.status(201).body(novoCliente); 
    }

    // *********** Deletar cadastro ************
    @DeleteMapping("/delete/{codInt}")
    public ResponseEntity<Void> apagarTitular(@PathVariable long codInt) {
        TitularConta clienteEncontrado = repo.findById(codInt).orElse(null);

        if (clienteEncontrado == null) {
            return ResponseEntity.status(404).build();
        }

        repo.deleteById(codInt);
        return ResponseEntity.ok().build();
    }
}
