import { NgModule } from '@angular/core';

import { LivroService } from './services/livro.datasource.service'

import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';


import { AppComponent     } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent    } from './components/home/home.component';
import { LivroComponent   } from './components/livro/livro.component';
import { EditLivroComponent        } from './components/livro/edit/livro.edit.component'

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        LivroComponent,
        EditLivroComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'livro', component: LivroComponent },
            { path: 'livro/incluir', component: EditLivroComponent },
            { path: 'livro/alterar/:id', component: EditLivroComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [LivroService]
})
export class AppModuleShared {
}
