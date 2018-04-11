import { Component, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl, FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { LivroComponent } from '../../livro/livro.component';
import { LivroService } from '../../../services/livro.datasource.service';

@Component({
    selector: 'livro/incluir',
    templateUrl: './livro.edit.component.html',
    styleUrls: ['./livro.edit.component.css']
})

export class EditLivroComponent implements OnInit {
    livroForm: FormGroup;
    title: string = "Incluir";
    id: number;
    errorMessage: any;

    constructor(private formBuild: FormBuilder, private activateRoute: ActivatedRoute,
        private livroService: LivroService, private router: Router) {
        
        if (this.activateRoute.snapshot.params["id"]) {
            this.id = this.activateRoute.snapshot.params["id"];
        }

        this.livroForm = this.formBuild.group({
            id: 0,
            titulo: ['', [Validators.required]],
            autor: ['', [Validators.required]],
            paginas: ['', [Validators.required]],
            edicao: '',
            idioma: ['', [Validators.required]],
            editora: ['', [Validators.required]],
            descricao: '',
            dataPublicacao: '',
            isbN10: '',
            isbN13: '',
            estoque: 0,
            active: true,
            createdAt: new Date(),
            editedAt: new Date()
        })
    }

    ngOnInit() {
        if (this.id > 0) {
            this.title = "Alterar";
            this.livroService.getLivro(this.id)
                .subscribe(resp => this.livroForm.setValue(resp), 
                    error => this.errorMessage = error);
        }
    }

    save() {
        if (!this.livroForm.valid) {
            return;
        }
        
        if (this.title == 'Incluir') {
            this.livroService.saveLivro(this.livroForm.value)
                .subscribe((data) => {
                    this.livroService.getLivros();
                    this.router.navigate(['/livro']);
                }, error => this.errorMessage = error)
        }
        else if (this.title == 'Alterar') {
            this.livroService.updateLivro(this.livroForm.value)
                .subscribe((data) => {
                    this.router.navigate(['/livro']);
                }, error => this.errorMessage = error) 
        }
    }

    cancel() {
        this.router.navigate(['/livro']);
    }

    get titulo() { return this.livroForm.get('titulo'); }
    get autor() { return this.livroForm.get('autor'); }
    get paginas() { return this.livroForm.get('paginas'); }
    get edicao() { return this.livroForm.get('edicao'); }
    get idioma() { return this.livroForm.get('idioma'); }
    get editora() { return this.livroForm.get('editora'); }
    get descricao() { return this.livroForm.get('descricao'); }
    get dataPublicacao() { return this.livroForm.get('dataPublicacao'); }
    get isbN10() { return this.livroForm.get('isbn10'); }
    get isbN13() { return this.livroForm.get('isbn13'); }
    get estoque() { return this.livroForm.get('estoque'); } 
    get active() { return this.livroForm.get('active'); } 
    get createdAt() { return this.livroForm.get('createdAt'); } 
    get editedAt() { return this.livroForm.get('editedAt'); } 
}

