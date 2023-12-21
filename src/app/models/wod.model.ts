export interface Workout {
  id: number;
  wodCat: string;
  rounds: number;
  mpr: number;
  r1m1: string;
  r1m2?: string;
  r1m3?: string;
  r1sets?: number;
  r1move?: number;
  r1rest?: number;
  r2m1?: string;
  r2m2?: string;
  r2m3?: string;
  r2sets?: number;
  r2move?: number;
  r2rest?: number;
  r3m1?: string;
  r3m2?: string;
  r3m3?: string;
  r3sets?: number;
  r3move?: number;
  r3rest?: number;
  r4m1?: string;
  r4m2?: string;
  r4m3?: string;
  r4sets?: number;
  r4move?: number;
  r4rest?: number;
  daDate: string;
  styleId: number;
  styleName?: string;
  styleDescription?: string;
  exe?: Exercises;
  exeR1M2?: Exercises;
  exeR1M3?: Exercises;
  exeR2M1?: Exercises;
  exeR2M2?: Exercises;
  exeR2M3?: Exercises;
  exeR3M1?: Exercises;
  exeR3M2?: Exercises;
  exeR3M3?: Exercises;
  exeR4M1?: Exercises;
  exeR4M2?: Exercises;
  exeR4M3?: Exercises;
  [key: string]: any;
}

export class Style {
  constructor(
    public styleId: number,
    public styleName: string,
    public styleDescription: string
  ) {}
}
export interface Exercises{
  exeId: number;
  exeName: string;
  videoUrl: string;
  mobileUrl: string;
}
export class Exercise {
  constructor(
    public   exeId: number,
    public  exeName: string,
    public  videoUrl: string,
    public  mobileUrl: string,
    
  ){}
  
}

export interface User{
  userId: number;
  name: string;
  email: string;
  password: string;

  role: string;
  
}

export class UserType {
  constructor(
    public userTypeId: number,
    public userTypeName: string
  ) {}
}
