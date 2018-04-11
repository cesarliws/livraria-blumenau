import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'livro',
    templateUrl: './livro.component.html'
})

export class LivroComponent {
    public livros: Livro[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/livro').subscribe(result => {
            this.livros = result.json() as Livro[];
        }, error => console.error(error));
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
    ISBN10: string;
    ISBN13: string;
    estoque: number;
}
