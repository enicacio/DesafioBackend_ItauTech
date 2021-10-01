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
@RequestMapping("/tipo")
@CrossOrigin("*")
public class TipodeContaController {

    @Autowired
    private TipodeRepo repo;

    // *********** Buscar em contas pelo tipo de conta ***********
    @GetMapping("/{tipoConta}") 
    public ResponseEntity<TipodeConta> obterTipoConta(@PathVariable int tipoConta) {
        TipodeConta contaEncontrada = repo.findById(tipoConta).orElse(null);
        
        if (contaEncontrada != null) {
            return ResponseEntity.ok(contaEncontrada);
        } else {
            return ResponseEntity.notFound().build();
        }
    }
}

