import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Itask } from '../model/task';
@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit{
  todoForm !: FormGroup;
  tasks : Itask [] =[];
  inprogress:Itask[]=[];
  done:Itask[]=[];
  constructor(private fb : FormBuilder){}

ngOnInit(): void{
  this.todoForm = this.fb.group({
    item:['',Validators.required]
  })
}
addTask(){
  this.tasks.push({
    description:this.todoForm.value.item,
    done:false
  })
}
drop(event: CdkDragDrop<Itask[]>) {
  if (event.previousContainer === event.container) {
    moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
  } else {
    transferArrayItem(
      event.previousContainer.data,
      event.container.data,
      event.previousIndex,
      event.currentIndex,
    );
  }
}
}
