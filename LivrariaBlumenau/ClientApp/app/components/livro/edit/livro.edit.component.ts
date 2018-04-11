import { Component, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { LivroComponent } from '../../livro/livro.component';
import { LivroService } from '../../../services/livro.datasource.service';

@Component({
    selector: 'livro-incluir',
    templateUrl: './livro.edit.component.html'
})

export class EditLivro implements OnInit {
    livroForm: FormGroup;
    title: string = "Incluir";
    id: number;
    errorMessage: any;

    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute,
        private _livroService: LivroService, private _router: Router) {
        if (this._avRoute.snapshot.params["id"]) {
            this.id = this._avRoute.snapshot.params["id"];
        }

        this.livroForm = this._fb.group({
            id: 0,
            titulo: ['', [Validators.required]],
            autor: ['', [Validators.required]],
            paginas: ['', [Validators.required]],
            editora: ['', [Validators.required]],
            dataPublicacao: ['', [Validators.required]]
        })
    }

    ngOnInit() {
        if (this.id > 0) {
            this.title = "Alterar";
            this._livroService.getLivro(this.id)
                .subscribe(resp => this.livroForm.setValue(resp), 
                    error => this.errorMessage = error);
        }
    }

    save() {
        if (!this.livroForm.valid) {
            return;
        }

        if (this.title == "Incluir") {
            this._livroService.saveLivro(this.livroForm.value)
                .subscribe((data) => {
                    this._router.navigate(['/livro']);
                }, error => this.errorMessage = error)
        }
        else if (this.title == "Alterar") {
            this._livroService.updateLivro(this.livroForm.value)
                .subscribe((data) => {
                    this._router.navigate(['/livro']);
                }, error => this.errorMessage = error) 
        }
    }

    cancel() {
        this._router.navigate(['/livro']);
    }

    get titulo() { return this.livroForm.get('titulo'); }
    get autor() { return this.livroForm.get('autor'); }
    get paginas() { return this.livroForm.get('paginas'); }
    get editora() { return this.livroForm.get('editora'); }
    get dataPublicacao() { return this.livroForm.get('dataPublicacao'); }
}

