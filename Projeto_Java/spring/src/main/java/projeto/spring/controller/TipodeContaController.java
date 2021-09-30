package projeto.spring.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import projeto.spring.model.TipodeConta;
import projeto.spring.repository.TipodeRepo;

@RestController
@RequestMapping("/contas/tipo")
@CrossOrigin("*")
public class TipodeContaController {

    @Autowired
    private TipodeRepo repo;

    // *********** Buscar em contas pelo tipo de conta ***********
    @GetMapping("/{tipoConta}") 
    public Object buscaContaTipo(@PathVariable int tipoConta) {
        return repo.buscaContaTipo(tipoConta);
    }
    
}
