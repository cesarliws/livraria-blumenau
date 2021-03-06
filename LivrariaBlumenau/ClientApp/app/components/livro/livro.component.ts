import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { LivroService } from '../../services/livro.datasource.service';


@Component({
    selector: 'livro',
    templateUrl: './livro.component.html'
})

export class LivroComponent {
    public livros: Livro[];

    constructor(private livroService: LivroService, private http: Http,
          @Inject('BASE_URL') private baseUrl: string) {
        this.getLivros();
    }

    getLivros() {
        this.http.get(this.baseUrl + 'api/livro/Index').subscribe(result => {
            this.livros = result.json() as Livro[];
        }, error => console.error(error));
    }

    delete(id: number, titulo: string) {
        if (confirm(`"${titulo}"\nExcluir o Livro?`)) {
            this.livroService.deleteLivro(id).subscribe((data) => {
                this.getLivros();
            }, error => console.error(error)) 
        }
    }
}

interface Livro {
    id: number;
    titulo: string;
    autor: string;
    paginas: number;
    edicao: string;
    idioma: string;
    editora: string;
    descricao: string;
    dataPublicacao: Date;
    isbN10: string;
    isbN13: string;
    estoque: number;
    active: boolean;
    createdAt: Date;
    editedAt: Date;
}
